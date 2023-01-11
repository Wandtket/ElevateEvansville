using Microsoft.EntityFrameworkCore;

namespace ElevateEvansville_API.Models
{
    public class Signatures : BaseEntity<int>
    {

        public string? LastName { get; set; }

        public string? FirstName { get; set; }

        public string? Address { get; set; }

        public string? Zip { get; set; }

        public string? Notes { get; set; }

        public string? Phone { get; set; }

        public string? Email { get; set; }

        public TimeSpan? PreferredTimeStart { get; set; }

        public TimeSpan? PreferredTimeEnd { get; set; }

        public bool? Anytime { get; set; }

        public bool? PrefersMonday { get; set; }

        public bool? PrefersTuesday { get; set; }

        public bool? PrefersWednesday { get; set; }

        public bool? PrefersThursday { get; set; }

        public bool? PrefersFriday { get; set; }

        public bool? PrefersSaturday { get; set; }

        public bool? PrefersSunday { get; set; }

        public bool? MaskRequested { get; set; }

        public bool? NotHome { get; set; }

        public bool? SignatureCollected { get; set; }

        public int? SignatureCount { get; set; }

        public DateTime? SignatureCollectedDateTime { get; set; }

        public int? SignatureCollectedUserId { get; set; }
    }

    public class SignaturesContext : DbContext
    {
        public SignaturesContext(DbContextOptions options) : base(options) { }

        DbSet<Signatures> Signatures { get; set; }
    }
}
