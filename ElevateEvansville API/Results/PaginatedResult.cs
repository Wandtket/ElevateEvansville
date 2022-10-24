using ElevateEvansville_API.Responses.Envelopes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ElevateEvansville_API.Results
{
    public class PaginatedResult<T>
        : JsonResult
        where T : class
    {
        public PaginatedResult(IEnumerable<T> data) : base(new PaginatedEnvelope<T>(data))
        {
            StatusCode = 200;
        }

        public PaginatedResult(IEnumerable<T> data, string? nextUrl) : base(new PaginatedEnvelope<T>(data, nextUrl))
        {
            StatusCode = 200;
        }
    }
}
