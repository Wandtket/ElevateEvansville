using ElevateEvansville_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Diagnostics.Contracts;

namespace ElevateEvansville_API.Configurations
{
    public class BalanceConfiguration : IEntityTypeConfiguration<Balance>
    {
        public void Configure(EntityTypeBuilder<Balance> builder)
        {
            builder.ToTable("Balance");

            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id)
                .HasColumnName("BalanceID");

            //builder.Property(c => c.VendorLocationID)
            //    .HasColumnName("VndLocID");

            //builder.Property(c => c.ContractYYMM)
            //    .HasColumnName("ContrYYMM");
        
        }

    }
}
