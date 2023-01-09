using ElevateEvansville_API.Models;
using Microsoft.EntityFrameworkCore;

namespace ElevateEvansville_API
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Accounts> Accounts { get; set; }

        public DbSet<Transactions> Transactions { get; set;  }

        public DbSet<Signatures> Signatures { get; set; }


        public DatabaseContext(DbContextOptions options) : base(options) { }
    }
}
