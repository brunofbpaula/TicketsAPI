using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickets.Domain.Entities.Ticket;
using Tickets.Domain.Enums;

namespace Tickets.Domain.Interfaces
{
    public interface ITicketRepository
    {
        Task<IEnumerable<Ticket>> GetAllTickets();
        Task<IEnumerable<Ticket>> GetUserTickets(Guid id);
        Task<IEnumerable<Ticket>> GetUserTicketsByStatus(Guid id, TicketStatus ticketStatus);
        Task<Ticket> GetTicketById(Guid id);
        Task<Ticket> AddTicket(Ticket ticket);
        void UpdateTicket(Ticket ticket);
        Task<Ticket> DeleteTicket(Guid id);
    }
}
