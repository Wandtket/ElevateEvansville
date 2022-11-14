using ElevateEvansville_API.Models;
using ElevateEvansville_API.Repositories.Interfaces;
using ElevateEvansville_API.Repositories.Internal;

namespace ElevateEvansville_API.Repositories
{

    public interface IBalanceRepository : IRepository<Balances>
    {


    }


    public class BalanceRepository : BaseRepository<Balances>, IBalanceRepository
    {
        public BalanceRepository(DatabaseContext context) : base(context) { }

    }

}
