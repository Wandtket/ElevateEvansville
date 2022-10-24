using System.Text.Json.Serialization;

namespace ElevateEvansville_API.Responses
{
    public class BaseResponse
    {
        [JsonPropertyName("response_id")]
        public Guid ResponseId { get; private set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("request_id")]
        public Guid? RequestId { get; private set; } = null;

        protected BaseResponse()
        {
            ResponseId = Guid.NewGuid();
        }

        protected BaseResponse(Guid requestId) : this()
        {
            RequestId = requestId;
        }
    }
}
