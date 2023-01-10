using ElevateEvansville_API.Models;
using ElevateEvansville_API.Repositories.Interfaces;
using ElevateEvansville_API.Repositories.Internal;

namespace ElevateEvansville_API.Repositories
{

    public interface IAccountsRepository : IRepository<Accounts>
    {
        Task<bool> IsEmailUsed(string Email);

        Task<bool> ValidatePassword(string Email, string Password);

        Task<Accounts> GetByEmail(string Email);
    }


    public class AccountsRepository : BaseRepository<Accounts>, IAccountsRepository
    {
        public AccountsRepository(DatabaseContext context) : base(context) { }

        public async Task<Accounts> GetByEmail(string Email)
        {
            var Account = Context.Accounts.Where(x => x.Email == Email).FirstOrDefault();
            if (Account == null) { return null; }
            else { return Account; }
        }

        public async Task<bool> IsEmailUsed(string Email)
        {
            var Account = Context.Accounts.Where(x => x.Email == Email).FirstOrDefault();

            if (Account == null) { return false; }
            else { return true; }
        }

        public async Task<bool> ValidatePassword(string Email, string Password)
        {
            var Account = Context.Accounts.Where(x => x.Email == Email).FirstOrDefault();

            if (Account.Password == Password) { return true; }
            else { return false; }
        }

    }
}
