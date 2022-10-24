using System.Text.Json.Serialization;

namespace ElevateEvansville_API.Models
{
    public class Requests : BaseEntity<int>
    {
        public int? RequestID { get; set; }

    }
}
