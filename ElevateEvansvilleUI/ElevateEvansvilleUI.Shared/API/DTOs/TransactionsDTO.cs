using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ElevateEvansvilleUI.DTOs
{
    public class TransactionsDTO
    {
        [JsonPropertyName("TransactionID")]
        public string TransactionID { get; set; }

        [JsonPropertyName("Class")]
        public string Class { get; set; }

        [JsonPropertyName("Status")]
        public string Status { get; set; }

        [JsonPropertyName("Type")]
        public string Type { get; set; }

        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("Memo")]
        public string Memo { get; set; }

        [JsonPropertyName("PayerCensoredName")]
        public string PayerCensoredName { get; set; }

        [JsonPropertyName("FeeAmount")]
        public string FeeAmount { get; set; }

        [JsonPropertyName("GrossAmount")]
        public string GrossAmount { get; set; }

        [JsonPropertyName("NetAmount")]
        public string NetAmount { get; set; }

        [JsonPropertyName("Timestamp")]
        public DateTime Timestamp { get; set; }
    }

    public class TransactionListDTO
    {
        [JsonPropertyName("TransactionList")]
        public IEnumerable<TransactionsDTO> Transactions { get; set; }
    }

}
