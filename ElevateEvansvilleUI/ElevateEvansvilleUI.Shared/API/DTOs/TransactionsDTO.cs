using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ElevateEvansvilleUI.DTOs
{
    internal class TransactionsDTO
    {
        [JsonPropertyName("TransactionID")]
        public int TransactionID { get; set; }

        [JsonPropertyName("TransactionType")]
        public string TransactionType { get; set; }
    }
}
