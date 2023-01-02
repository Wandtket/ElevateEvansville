using ElevateEvansville_API.Models;
using ElevateEvansville_API.Repositories.Interfaces;
using ElevateEvansville_API.Repositories.Internal;

namespace ElevateEvansville_API.Repositories
{

    public interface ISignaturesRepository : IRepository<Signatures>
    {


    }


    public class SignaturesRepository : BaseRepository<Signatures>, ISignaturesRepository
    {
        public SignaturesRepository(DatabaseContext context) : base(context) { }
    }
}
