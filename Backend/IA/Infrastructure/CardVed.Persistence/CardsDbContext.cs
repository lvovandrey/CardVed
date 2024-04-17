using CardVed.Application.Interfaces;
using CardVed.Core;
using CardVed.Persistence.EntityTypeConfigurations;
using Microsoft.EntityFrameworkCore;

namespace CardVed.Persistence
{
    public class CardsDbContext : DbContext, ICardsDbContext
    {
        public DbSet<Card> Cards { get; set; }

        public CardsDbContext(DbContextOptions<CardsDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CardConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
