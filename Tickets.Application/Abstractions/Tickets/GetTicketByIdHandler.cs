using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickets.Application.Abstractions.Queries;
using Tickets.Domain.Entities.Ticket;
using Tickets.Domain.Interfaces;

namespace Tickets.Application.Abstractions.Tickets
{
    public class GetTicketByIdHandler : IRequestHandler<GetTicketByIdQuery, Ticket>
    {
        private readonly ITicketRepository _ticketRepository;

        public GetTicketByIdHandler(ITicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }

        public async Task<Ticket> Handle(GetTicketByIdQuery request, CancellationToken cancellationToken)
        {
            var ticket = await _ticketRepository.GetTicketById(request.Id);
            return ticket;
        }


    }
}
