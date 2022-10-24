using ElevateEvansville_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ElevateEvansville_API.Configurations
{
    public class RequestsConfiguration : IEntityTypeConfiguration<Requests>
    {
        public void Configure(EntityTypeBuilder<Requests> builder)
        {
            builder.ToTable("Requests");

            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id)
                .HasColumnName("RequestID");

            //builder.Property(c => c.VendorLocationID)
            //    .HasColumnName("VndLocID");

            //builder.Property(c => c.ContractYYMM)
            //    .HasColumnName("ContrYYMM");

        }
    }
}
