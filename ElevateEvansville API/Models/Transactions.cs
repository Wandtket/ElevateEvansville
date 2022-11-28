using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ElevateEvansville_API.Models
{
    public class Transactions : BaseEntity<int>
    {

        public string? PaypalTransactionID { get; set; }

        public string? Class { get; set; }

        public string? Status { get; set; }

        public string? Type { get; set; }

        public string? Name { get; set; }

        public string? Memo { get; set; }

        public string? Payer { get; set; }

        public string? PayerDisplayName { get; set; }

        public string? PayerCensoredName { get; set; }

        public string? FeeAmount { get; set; }

        public string? GrossAmount { get; set; }

        public string? NetAmount { get; set; }

        public DateTime? Timestamp { get; set; }
    }

    public class PayPalTransactionContext : DbContext
    {
        public PayPalTransactionContext(DbContextOptions options) : base(options) { }
        DbSet<Transactions> PayPalTransaction
        {
            get;
            set;
        }
    }
}
