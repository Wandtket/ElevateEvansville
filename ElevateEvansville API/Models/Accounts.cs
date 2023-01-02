using Microsoft.EntityFrameworkCore;

namespace ElevateEvansville_API.Models
{
    public class Accounts : BaseEntity<int>
    {

        public string? Email { get; set; }

        public string? Password { get; set; }

        public string? LastName { get; set; }

        public string? FirstName { get; set; }

        public string? Phone { get; set; }

    }

    public class AccountsContext : DbContext
    {
        public AccountsContext(DbContextOptions options) : base(options) { }

        DbSet<Accounts> Accounts { get; set; }
    }
}
