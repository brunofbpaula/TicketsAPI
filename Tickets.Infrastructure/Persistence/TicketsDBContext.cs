using Microsoft.EntityFrameworkCore;
using Tickets.Domain.Entities.Ticket;

namespace Tickets.Infrastructure.Persistence
{
    internal class TicketsDBContext(DbContextOptions<TicketsDBContext> options) : DbContext(options)
    {
        internal DbSet<Ticket> Tickets { get; set; }

    }
}
