using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets.Application.Abstractions.Messaging
{
    internal interface ICommandHandler<TCommand>
    {
        Task Handle(TCommand command, CancellationToken cancellationToken);
    }
}
