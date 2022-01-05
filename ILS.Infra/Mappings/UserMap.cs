using ILD.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ILS.Infra.Mappings
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .UseMySqlIdentityColumn()
                .HasColumnType("BIGINT");

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(80)
                .HasColumnName("name")
                .HasColumnType("VARCHAR(80)");

            
            builder.Property(x => x.Cpf)
                .IsRequired()
                .HasMaxLength(14)
                .HasColumnName("cpf")
                .HasColumnType("VARCHAR(14)");

            
            builder.Property(x => x.BirthDate)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnName("birthdate")
                .HasColumnType("VARCHAR(10)");
        }
    }
}
