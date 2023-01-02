using ElevateEvansville_API.Models;
using ElevateEvansville_API.Repositories.Interfaces;
using ElevateEvansville_API.Repositories.Internal;

namespace ElevateEvansville_API.Repositories
{

    public interface IAccountsRepository : IRepository<Accounts>
    {


    }


    public class AccountsRepository : BaseRepository<Accounts>, IAccountsRepository
    {
        public AccountsRepository(DatabaseContext context) : base(context) { }
    }
}
