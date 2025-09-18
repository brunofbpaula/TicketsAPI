using Microsoft.EntityFrameworkCore;
using Tickets.Domain.Entities.Ticket;
using Tickets.Domain.Entities.User;

namespace Tickets.Infrastructure.Persistence
{
    internal class TicketsDBContext(DbContextOptions<TicketsDBContext> options) : DbContext(options)
    {
        internal DbSet<Ticket> Tickets { get; set; }
        internal DbSet<User> Users { get; set; }

    }
}
