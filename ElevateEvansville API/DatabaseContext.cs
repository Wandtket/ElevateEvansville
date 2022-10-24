using ElevateEvansville_API.Models;
using Microsoft.EntityFrameworkCore;

namespace ElevateEvansville_API
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options) { }

        DbSet<Balance> Balance
        {
            get;
            set;
        }

    }
}
