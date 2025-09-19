using MediatR;
using Tickets.Domain.Entities.Ticket;

namespace Tickets.Application.Abstractions.Commands
{
    public record CreateTicketCommand(Guid RequesterId, string Title, string Description) : IRequest<Ticket>;
}
