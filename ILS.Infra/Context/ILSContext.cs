using ILD.Domain.Entities;
using ILS.Infra.Mappings;
using Microsoft.EntityFrameworkCore;

namespace ILS.Infra.Context
{
    public class ILSContext : DbContext{
        public ILSContext()
        { }

        public ILSContext(DbContextOptions<ILSContext> options) : base(options)
        {}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(ServerVersion.AutoDetect("server=localhost; port=3306; database=ILS; user=root; password=12345678; Persist Security Info=False; Connect Timeout=300"));
        }

        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserMap());
        }
    }
}