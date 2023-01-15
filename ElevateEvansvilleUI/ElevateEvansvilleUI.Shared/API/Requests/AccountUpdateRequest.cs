using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ElevateEvansvilleUI.API.Requests
{

    public class AccountUpdateRequest
    {

        [JsonPropertyName("CurrentEmail")]
        public string CurrentEmail { get; set; }

        [JsonPropertyName("NewEmail")]
        public string NewEmail { get; set; }

        [JsonPropertyName("CurrentPassword")]
        public string CurrentPassword { get; set; }

        [JsonPropertyName("NewPassword")]
        public string NewPassword { get; set; }

        [JsonPropertyName("NewPhone")]
        public string NewPhone { get; set; }

    }
}
