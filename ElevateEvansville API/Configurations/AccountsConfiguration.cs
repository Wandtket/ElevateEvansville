using ElevateEvansville_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ElevateEvansville_API.Configurations
{
    public class AccountsConfiguration : IEntityTypeConfiguration<Accounts>
    {
        public void Configure(EntityTypeBuilder<Accounts> builder)
        {
            builder.ToTable("Accounts");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Email)
                .HasColumnName("Email");

            builder.Property(c => c.Password)
                .HasColumnName("Password");

            builder.Property(c => c.LastName)
                .HasColumnName("LastName");

            builder.Property(c => c.FirstName)
                .HasColumnName("FirstName");

            builder.Property(c => c.Phone)
               .HasColumnName("Phone");         

        }

    }
}
