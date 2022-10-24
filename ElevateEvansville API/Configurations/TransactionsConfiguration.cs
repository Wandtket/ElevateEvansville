using ElevateEvansville_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ElevateEvansville_API.Configurations
{

    public class TransactionsConfiguration : IEntityTypeConfiguration<Transactions>
    {
        public void Configure(EntityTypeBuilder<Transactions> builder)
        {
            builder.ToTable("Transactions");

            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id)
                .HasColumnName("TransactionID");

            //builder.Property(c => c.VendorLocationID)
            //    .HasColumnName("VndLocID");

            //builder.Property(c => c.ContractYYMM)
            //    .HasColumnName("ContrYYMM");

        }
    }
}
