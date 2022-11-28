using ElevateEvansville_API.Models;
using ElevateEvansville_API.Repositories.Interfaces;
using ElevateEvansville_API.Repositories.Internal;
using Microsoft.EntityFrameworkCore;

namespace ElevateEvansville_API.Repositories
{

    public interface ITransactionRepository : IRepository<Transactions>
    {

        public Task AddItem(Transactions transaction);

        public Task<bool> IsTransactionDuplicate(string PaypalTransactionID);

        public Task<DateTime> GetQueryStartDate();
    }


    public class TransactionsRepository : BaseRepository<Transactions>, ITransactionRepository
    {
        public TransactionsRepository(DatabaseContext context) : base(context) { }

        public async Task AddItem(Transactions transaction)
        {
            //Create a censored name for small dollar donations.
            if (transaction.PayerDisplayName != null)
            {    
                if (Convert.ToDouble(transaction.GrossAmount) < 25.00)
                {
                    //Censor the name of the individual if contribution is small dollar.
                    try
                    {
                        string DisplayName = transaction.PayerDisplayName.Trim();
                        string FirstName = DisplayName.Substring(0, DisplayName.IndexOf(" "));
                        string LastName = DisplayName.Replace(FirstName, "").Trim();

                        string FirstCensoredName = FirstName.Substring(0, 1) + "***";
                        string LastCensoredName = LastName.Substring(0, 1) + "***";

                        transaction.PayerCensoredName = FirstCensoredName + " " + LastCensoredName;
                    }
                    catch { transaction.PayerCensoredName = "***"; }
                }
                else
                {
                    //Send the payer name if it's more than $25.
                    transaction.PayerCensoredName = transaction.PayerDisplayName;
                }
            }

            //Remove the prefix needed for paypal transaction history.
            if (transaction.Name.Contains("Elevate Evansville - "))
            {
                transaction.Name = transaction.Name.Replace("Elevate Evansville - ", "");
            }

            await Context.Transactions.AddAsync(transaction);
        }


        public async Task<bool> IsTransactionDuplicate(string PaypalTransactionID)
        {
            var Entry = Context.Transactions.FirstOrDefault(x => x.PaypalTransactionID == PaypalTransactionID);

            if (Entry == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public async Task<DateTime> GetQueryStartDate()
        {
            var Entry = Context.Transactions.OrderByDescending(x => x.Timestamp).FirstOrDefault();

            if (Entry == null) { return DateTime.Now.AddDays(-999); }

            return (DateTime)Entry.Timestamp;
        }


    }

    
}
