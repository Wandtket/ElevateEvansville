using ElevateEvansville_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ElevateEvansville_API.Configurations
{

    public class SignaturesConfiguration : IEntityTypeConfiguration<Signatures>
    {
        public void Configure(EntityTypeBuilder<Signatures> builder)
        {
            builder.ToTable("Signatures");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.LastName)
                .HasColumnName("LastName");

            builder.Property(c => c.FirstName)
                .HasColumnName("FirstName");

            builder.Property(c => c.Address)
                .HasColumnName("Address");

            builder.Property(c => c.Zip)
                .HasColumnName("Zip");

            builder.Property(c => c.Email)
               .HasColumnName("Email");

            builder.Property(c => c.Phone)
               .HasColumnName("Phone");

            builder.Property(c => c.PreferredTimeStart)
               .HasColumnName("PreferredTimeStart");

            builder.Property(c => c.PreferredTimeEnd)
               .HasColumnName("PreferredTimeEnd");

            builder.Property(c => c.PrefersMonday)
               .HasColumnName("PrefersMonday");

            builder.Property(c => c.PrefersTuesday)
               .HasColumnName("PrefersTuesday");

            builder.Property(c => c.PrefersWednesday)
               .HasColumnName("PrefersWednesday");

            builder.Property(c => c.PrefersThursday)
               .HasColumnName("PrefersThursday");

            builder.Property(c => c.PrefersFriday)
               .HasColumnName("PrefersFriday");

            builder.Property(c => c.PrefersSaturday)
               .HasColumnName("PrefersSaturday");

            builder.Property(c => c.PrefersSunday)
               .HasColumnName("PrefersSunday");

            builder.Property(c => c.MaskRequested)
               .HasColumnName("MaskRequested");

            builder.Property(c => c.NotHome)
               .HasColumnName("NotHome");

            builder.Property(c => c.SignatureCollected)
               .HasColumnName("SignatureCollected");

            builder.Property(c => c.SignatureCount)
               .HasColumnName("SignatureCount");

            builder.Property(c => c.SignatureCollectedDateTime)
              .HasColumnName("SignatureCollectedDateTime");

            builder.Property(c => c.SignatureCollectedUserId)
              .HasColumnName("SignatureCollectedUserId");

        }

    }
}
