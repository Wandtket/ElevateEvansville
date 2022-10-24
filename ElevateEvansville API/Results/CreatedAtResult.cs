using ElevateEvansville_API.Responses.Envelopes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ElevateEvansville_API.Results
{
    public class CreatedAtResult<T>
    : JsonResult
    where T : class
    {
        public CreatedAtResult(string? url, T data) : base(new CreatedAtEnvelope<T>(url, data))
        {
            StatusCode = 201;
        }
    }
}
