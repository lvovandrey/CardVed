using CardVed.Core;
using Microsoft.EntityFrameworkCore;

namespace CardVed.Application.Interfaces
{
    public interface ICardsDbContext
    {
        DbSet<Card> Cards { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}