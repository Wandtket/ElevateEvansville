using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ElevateEvansville_API.Models
{
    /// <summary>
    /// dbo.Balance
    /// </summary>
    public class Balances : BaseEntity<int>
    {
        public string? TotalBalance { get; set; }

        public DateTime? Created { get; set; }
    }

    public class BalancesContext : DbContext
    {
        public BalancesContext(DbContextOptions options) : base(options) { }

        DbSet<Balances> Balances { get; set; }
    }
}