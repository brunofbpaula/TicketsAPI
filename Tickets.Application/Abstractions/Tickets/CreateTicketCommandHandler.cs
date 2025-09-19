using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickets.Application.Abstractions.Commands;
using Tickets.Domain.Entities.Ticket;
using Tickets.Domain.Enums;
using Tickets.Domain.Interfaces;

namespace Tickets.Application.Abstractions.Tickets
{
    public class CreateTicketCommandHandler : IRequestHandler<CreateTicketCommand, Ticket>
    {
        private readonly ITicketRepository _ticketRepository;

        public CreateTicketCommandHandler(ITicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }

        public async Task<Ticket> Handle(CreateTicketCommand request, CancellationToken cancellationToken)
        {
            var ticket = new Ticket(request.RequesterId, request.Title, request.Description);
            return await _ticketRepository.AddTicket(ticket);
        }
    }
}
