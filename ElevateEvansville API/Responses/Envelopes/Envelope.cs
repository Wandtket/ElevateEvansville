using System.Text.Json.Serialization;

namespace ElevateEvansville_API.Responses.Envelopes
{
    public class Envelope : BaseEnvelope
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("message")]
        public string? Message { get; private set; }

        public Envelope(object? data) : base(data) { }

        public Envelope(string message, object? data = null) : base(data)
        {
            Message = message;
        }
    }

    public class Envelope<TData>
        : BaseEnvelope<TData>
        where TData : class
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("message")]
        public string? Message { get; private set; }

        public Envelope(TData? data) : base(data) { }

        public Envelope(string message, TData? data = null) : base(data)
        {
            Message = message;
        }
    }
}
