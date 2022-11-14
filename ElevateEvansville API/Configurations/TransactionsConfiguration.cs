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

            builder.Property(c => c.PaypalTransactionID)
                .HasColumnName("PaypalTransactionID");

            builder.Property(c => c.Status)
                .HasColumnName("Status");

            builder.Property(c => c.Type)
                .HasColumnName("Type");

            builder.Property(c => c.Name)
                .HasColumnName("Name");

            builder.Property(c => c.Memo)
               .HasColumnName("Memo");

            builder.Property(c => c.Payer)
               .HasColumnName("Payer");

            builder.Property(c => c.PayerDisplayName)
               .HasColumnName("PayerDisplayName");

            builder.Property(c => c.FeeAmount)
               .HasColumnName("FeeAmount");

            builder.Property(c => c.NetAmount)
               .HasColumnName("NetAmount");

            builder.Property(c => c.GrossAmount)
               .HasColumnName("GrossAmount");

            builder.Property(c => c.Timestamp)
               .HasColumnName("Timestamp");


            //builder.Property(c => c.ContractYYMM)
            //    .HasColumnName("ContrYYMM");

        }
    }
}
