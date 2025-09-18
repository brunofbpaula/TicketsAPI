using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tickets.Domain.Entities.Ticket;
using Tickets.Domain.Enums;
using Tickets.Domain.Exceptions;
using Tickets.Domain.Interfaces;
using Tickets.Infrastructure.Persistence;

namespace Tickets.Infrastructure.Repositories
{
    public class TicketRepository : ITicketRepository
    {
        private readonly TicketsDBContext db;

        public TicketRepository(TicketsDBContext dbContext)
        {
            db = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public async Task<IEnumerable<Ticket>> GetAllTickets()
        {
            return await db.Tickets.ToListAsync() ?? Enumerable.Empty<Ticket>();
        }

        public async Task<IEnumerable<Ticket>> GetUserTickets(Guid id)
        {
            return await db.Tickets
                           .Where(t => t.RequesterId == id)
                           .ToListAsync() ?? Enumerable.Empty<Ticket>();
        }

        public async Task<IEnumerable<Ticket>> GetUserTicketsByStatus(Guid id, TicketStatus ticketStatus)
        {
            return await db.Tickets
                           .Where(t => t.RequesterId == id && t.Status == ticketStatus)
                           .ToListAsync() ?? Enumerable.Empty<Ticket>();
        }

        public async Task<Ticket> GetTicketById(Guid id)
        {
            var ticket = await db.Tickets.FindAsync(id);
            if (ticket is null)
                throw new TicketNotFoundException(id);

            return ticket;
        }

        public async Task<Ticket> AddTicket(Ticket ticket)
        {
            if (ticket is null) throw new ArgumentNullException(nameof(ticket));

            await db.Tickets.AddAsync(ticket);
            await db.SaveChangesAsync();
            return ticket;
        }

        public void UpdateTicket(Ticket ticket)
        {
            if(ticket is null) throw new ArgumentNullException(nameof(ticket));

            db.Tickets.Update(ticket);
            db.SaveChanges();
        }

        public async Task<Ticket> DeleteTicket(Guid id)
        {
            var ticket = await GetTicketById(id);
            db.Tickets.Remove(ticket);
            await db.SaveChangesAsync();
            return ticket;
        }
    }
}
