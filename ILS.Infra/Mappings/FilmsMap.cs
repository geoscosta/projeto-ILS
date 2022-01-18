using ILS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ILS.Infra.Mappings
{
    public class FilmsMap : IEntityTypeConfiguration<Films>
    {
        public void Configure(EntityTypeBuilder<Films> builder)
        {
            builder.ToTable("Films");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .UseMySqlIdentityColumn()
                .HasColumnType("BIGINT");

            builder.Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(120)
                .HasColumnName("title")
                .HasColumnType("VARCHAR(120)");

            
            builder.Property(x => x.ParentalRating)
                .IsRequired()
                .HasColumnName("parentalrating")
                .HasColumnType("INT");

            
            builder.Property(x => x.Launch)
                .IsRequired()
                .HasColumnName("launch")
                .HasColumnType("TINYINT");
        }
    }
}
