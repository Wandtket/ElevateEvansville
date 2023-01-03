using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ElevateEvansvilleUI.API.DTOs
{
    public class SignaturesDTO
    {
        [JsonPropertyName("ID")]
        public int SignaturesID { get; set; }

        [JsonPropertyName("LastName")]
        public string LastName { get; set; }

        [JsonPropertyName("FirstName")]
        public string FirstName { get; set; }

        [JsonPropertyName("Address")]
        public string Address { get; set; }

        [JsonPropertyName("Zip")]
        public string Zip { get; set; }

        [JsonPropertyName("Phone")]
        public string Phone { get; set; }

        [JsonPropertyName("Email")]
        public string Email { get; set; }

        [JsonPropertyName("PreferredTimeStart")]
        public DateTime PreferredTimeStart { get; set; }

        [JsonPropertyName("PreferredTimeEnd")]
        public DateTime PreferredTimeEnd { get; set; }

        [JsonPropertyName("Anytime")]
        public bool Anytime { get; set; }

        [JsonPropertyName("PrefersMonday")]
        public bool PrefersMonday { get; set; }

        [JsonPropertyName("PrefersTuesday")]
        public bool PrefersTuesday { get; set; }

        [JsonPropertyName("PrefersWednesday")]
        public bool PrefersWednesday { get; set; }

        [JsonPropertyName("PrefersThursday")]
        public bool PrefersThursday { get; set; }

        [JsonPropertyName("PrefersFriday")]
        public bool PrefersFriday { get; set; }

        [JsonPropertyName("PrefersSaturday")]
        public bool PrefersSaturday { get; set; }

        [JsonPropertyName("PrefersSunday")]
        public bool PrefersSunday { get; set; }

        [JsonPropertyName("MaskRequested")]
        public bool MaskRequested { get; set; }

        [JsonPropertyName("NotHome")]
        public bool NotHome { get; set; }

        [JsonPropertyName("SignatureCollected")]
        public bool SignatureCollected { get; set; }

        [JsonPropertyName("SignatureCount")]
        public int SignatureCount { get; set; }

        [JsonPropertyName("SignatureCollectedDateTime")]
        public DateTime SignatureCollectedDateTime { get; set; }

        [JsonPropertyName("SignatureCollectedUserId")]
        public int SignatureCollectedUserId { get; set; }
    }
}
