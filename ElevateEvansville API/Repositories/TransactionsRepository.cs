using ElevateEvansville_API.Models;
using ElevateEvansville_API.Repositories.Interfaces;
using ElevateEvansville_API.Repositories.Internal;
using Microsoft.EntityFrameworkCore;

namespace ElevateEvansville_API.Repositories
{

    public interface ITransactionRepository : IRepository<Transactions>
    {

        public Task<bool> IsTransactionDuplicate(string PaypalTransactionID);

        public Task<DateTime> GetQueryStartDate();


    }


    public class TransactionsRepository : BaseRepository<Transactions>, ITransactionRepository
    {
        public TransactionsRepository(DatabaseContext context) : base(context) { }

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
