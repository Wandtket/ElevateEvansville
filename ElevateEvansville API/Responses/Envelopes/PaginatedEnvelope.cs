using System.Text.Json.Serialization;

namespace ElevateEvansville_API.Responses.Envelopes
{
    public class PaginatedEnvelope<T>
    : BaseEnvelope<IEnumerable<T>>
    where T : class
    {
        [JsonPropertyName("next_page")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? NextUrl { get; private set; }

        [JsonPropertyName("count")]
        public int Count { get; private set; }

        public PaginatedEnvelope(IEnumerable<T> data) : base(data)
        {
            Count = data.Count();
        }

        public PaginatedEnvelope(IEnumerable<T> data, string? nextUrl = null) : this(data)
        {
            NextUrl = nextUrl;
        }
    }
}
