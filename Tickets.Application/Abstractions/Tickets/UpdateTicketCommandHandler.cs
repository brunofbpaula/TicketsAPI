using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickets.Application.Abstractions.Commands;
using Tickets.Domain.Entities.Ticket;
using Tickets.Domain.Exceptions;
using Tickets.Domain.Interfaces;

namespace Tickets.Application.Abstractions.Tickets
{
    public class UpdateTicketCommandHandler : IRequestHandler<UpdateTicketCommand, Ticket>
    {
        private readonly ITicketRepository _ticketRepository;

        public UpdateTicketCommandHandler(ITicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }

        public async Task<Ticket> Handle(UpdateTicketCommand request, CancellationToken cancellationToken)
        {
            var ticket = await _ticketRepository.GetTicketById(request.Id);
            if (ticket is null) throw new TicketNotFoundException(request.Id);

            ticket.Title = request.Title;
            ticket.Description = request.Description;
            ticket.Status = request.Status;
            ticket.Priority = request.TicketPriority;
            ticket.LastUpdatedAt = DateTime.UtcNow;

            _ticketRepository.UpdateTicket(ticket);

            return ticket;

        }
    }
}
