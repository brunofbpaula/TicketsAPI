using Domain.Exceptions.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets.Domain.Exceptions
{
    public sealed class TicketNotFoundException : NotFoundException
    {
        public TicketNotFoundException(Guid Id) : base($"Ticket {Id} could not be found.") { }
    }
}
