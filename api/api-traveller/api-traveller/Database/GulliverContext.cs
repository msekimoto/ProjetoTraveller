using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace api_traveller.Controllers;

public partial class HoteisController
{
    public class GulliverContext : DbContext
    {
        public GulliverContext(DbContextOptions<GulliverContext> options) : base(options) 
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.Entity<Hotel>()
            //    .HasMany(b => b.Disponibilidades)
            //    .WithOne(b => b.Hotel);

        }

        public DbSet<Hotel> Hoteis { get; set; }
        public DbSet<Disponibilidade> Disponibilidades { get; set; }
    }
}
