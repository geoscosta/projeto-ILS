using ILS.Domain.Entities;
using ILS.Infra.Mappings;
using Microsoft.EntityFrameworkCore;

namespace ILS.Infra.Context
{
    public class ILSContext : DbContext{
      

        public ILSContext(DbContextOptions<ILSContext> options) : base(options)
        {}

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Films> Films { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserMap());
            builder.ApplyConfiguration(new FilmsMap());
        }
    }
}