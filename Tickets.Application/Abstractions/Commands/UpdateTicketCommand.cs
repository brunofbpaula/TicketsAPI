using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickets.Domain.Entities.Ticket;
using Tickets.Domain.Enums;

namespace Tickets.Application.Abstractions.Commands
{
    public record UpdateTicketCommand(Guid Id, 
        string Title, 
        string Description, 
        TicketStatus Status,
        TicketPriority TicketPriority
        ) : IRequest<Ticket>;
}
