using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickets.Domain.Entities.Ticket;

namespace Tickets.Domain.Interfaces
{
    internal interface ITicketRepository
    {
        IEnumerable<Ticket> GetAll();
        Ticket Get(int id);
        Ticket Save(Ticket ticket);
        Ticket Update(Ticket ticket);
        Ticket Delete(int id);
    }
}
