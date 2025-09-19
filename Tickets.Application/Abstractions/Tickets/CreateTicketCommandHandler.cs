using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickets.Application.Tickets.Commands;
using Tickets.Domain.Entities.Ticket;
using Tickets.Domain.Enums;
using Tickets.Domain.Interfaces;

namespace Tickets.Application.Abstractions.Tickets
{
    public class CreateTicketCommandHandler : IRequestHandler<CreateTicketCommand, Ticket>
    {
        private readonly ITicketRepository ticketRepository;

        public CreateTicketCommandHandler(ITicketRepository ticketRepository)
        {
            this.ticketRepository = ticketRepository;
        }

        public async Task<Ticket> Handle(CreateTicketCommand request, CancellationToken cancellationToken)
        {
            var ticket = new Ticket(request.RequesterId, request.Title, request.Description);
            return await ticketRepository.AddTicket(ticket);
        }
    }
}
