using System.Text.Json.Serialization;

namespace ElevateEvansville_API.Responses.Envelopes
{
    public class BaseEnvelope : BaseResponse
    {
        [JsonPropertyName("data")]
        public object? Data { get; private set; }

        protected BaseEnvelope() : this(null) { }

        protected BaseEnvelope(object? data) : base()
        {
            Data = data;
        }

        protected BaseEnvelope(Guid requestId, object? data) : base(requestId)
        {
            Data = data;
        }
    }

    public class BaseEnvelope<T>
        : BaseEnvelope
        where T : class
    {

        [JsonPropertyName("data")]
        public new T? Data { get; private set; }

        protected BaseEnvelope(T? data)
        {
            Data = data;
        }
    }
}
