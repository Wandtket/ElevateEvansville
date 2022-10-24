using System.Text.Json.Serialization;

namespace ElevateEvansville_API.Responses.Envelopes
{
    public class CreatedAtEnvelope<TData>
    : BaseEnvelope<TData>
    where TData : class
    {

        [JsonPropertyName("created_at")]
        public string? CreatedAt { get; private set; }

        public CreatedAtEnvelope(string? createdAt, TData data) : base(data)
        {
            CreatedAt = createdAt;
        }
    }
}
