using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ElevateEvansvilleUI.DTOs
{
    internal class RequestsDTO
    {
        [JsonPropertyName("RequestID")]
        public int RequestID { get; set; }
    }
}
