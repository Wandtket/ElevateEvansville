using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ElevateEvansville_API.Models
{
    /// <summary>
    /// dbo.Balance
    /// </summary>
    public class Balance : BaseEntity<int>
    {
        [Key]
        public int? ID { get; set; }

        public string? TotalBalance { get; set; }
    }

    public class BalanceContext : DbContext
    {
        public BalanceContext(DbContextOptions options) : base(options) { }
        DbSet<Balance> Balance
        {
            get;
            set;
        }
    }
}
