using ElevateEvansville_API.Responses.Envelopes;
using Microsoft.AspNetCore.Mvc;

namespace ElevateEvansville_API.Results
{
    public class EnvelopedResult<T>
       : JsonResult
       where T : class
    {
        public EnvelopedResult(T? data) : base(new Envelope<T>(data))
        {
            this.StatusCode = 200;
        }

        public EnvelopedResult(int statusCode, string message, T? data = null) : base(new Envelope<T>(message, data))
        {
            this.StatusCode = statusCode;
        }
    }

    public class EnvelopedResult : JsonResult
    {
        public EnvelopedResult(int statusCode, string message, object? data = null) : base(new Envelope(message, data))
        {
            this.StatusCode = statusCode;
        }

        public static EnvelopedResult Forbidden(string message)
        {
            return new EnvelopedResult(StatusCodes.Status403Forbidden, message);
        }

        public static EnvelopedResult NotFound(string message)
        {
            return new EnvelopedResult(StatusCodes.Status404NotFound, message);
        }
    }
}
