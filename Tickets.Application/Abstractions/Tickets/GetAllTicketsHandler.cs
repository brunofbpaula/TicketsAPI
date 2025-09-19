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
    public class GetAllTicketsHandler : IRequestHandler<GetAllTicketsQuery, IEnumerable<Ticket>>
    {
        private readonly ITicketRepository _ticketRepository;

        public GetAllTicketsHandler(ITicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }

        public async Task<IEnumerable<Ticket>> Handle(GetAllTicketsQuery request, CancellationToken cancellation)
        {
            return await _ticketRepository.GetAllTickets();
        }
    }
}
