using System.Text.Json.Serialization;

namespace ElevateEvansville_API.Models
{
    public class Transactions : BaseEntity<int>
    {
        public int? TransactionID { get; set; }

        public string? TransactionType { get; set; }
    }
}
