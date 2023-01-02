using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ElevateEvansvilleUI.API.DTOs
{
    public class BalanceDTO
    {
        [JsonPropertyName("ID")]
        public int BalanceID { get; set; }

        [JsonPropertyName("Balance")]
        public string Balance { get; set; }
    }
}
