using ElevateEvansville_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Diagnostics.Contracts;

namespace ElevateEvansville_API.Configurations
{
    public class BalanceConfiguration : IEntityTypeConfiguration<Balances>
    {
        public void Configure(EntityTypeBuilder<Balances> builder)
        {
            builder.ToTable("Balances");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.TotalBalance)
                .HasColumnName("TotalBalance");

            //builder.Property(c => c.ContractYYMM)
            //    .HasColumnName("ContrYYMM");

        }

    }
}
