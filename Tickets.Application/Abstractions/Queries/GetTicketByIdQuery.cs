using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickets.Domain.Entities.Ticket;

namespace Tickets.Application.Abstractions.Queries
{
    public record GetTicketByIdQuery(Guid Id) : IRequest<Ticket>;
}
