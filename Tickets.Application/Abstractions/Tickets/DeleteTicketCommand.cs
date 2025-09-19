using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickets.Application.Abstractions.Commands;
using Tickets.Domain.Interfaces;

namespace Tickets.Application.Abstractions.Tickets
{
    public class DeleteTicketCommandHandler : IRequestHandler<DeleteTicketCommand, Unit>
    {
        private readonly ITicketRepository _repository;
    
        public DeleteTicketCommandHandler(ITicketRepository ticketRepository)
        {
            _repository = ticketRepository;
        }

        public async Task<Unit> Handle(DeleteTicketCommand request, CancellationToken cancellationToken)
        {
            await _repository.DeleteTicket(request.Id);
            return Unit.Value;
        }
    
    }
}
