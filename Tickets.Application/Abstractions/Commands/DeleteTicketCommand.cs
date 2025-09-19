using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickets.Domain.Entities.Ticket;

namespace Tickets.Application.Abstractions.Commands
{
    public record DeleteTicketCommand(Guid Id) : IRequest<Unit>
    {
    }
}
