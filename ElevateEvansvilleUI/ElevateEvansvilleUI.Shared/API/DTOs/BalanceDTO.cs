using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ElevateEvansvilleUI.DTOs
{
    internal class BalanceDTO
    {
        [JsonPropertyName("ID")]
        public int ID { get; set; }


        [JsonPropertyName("TotalBalance")]
        public string TotalBalance { get; set; }

        
    }
}
