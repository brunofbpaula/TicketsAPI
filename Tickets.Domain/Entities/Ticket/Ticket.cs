using Tickets.Domain.Enums;
using Tickets.Domain.Primitives;

namespace Tickets.Domain.Entities.Ticket
{
    public class Ticket : Entity
    {

        public Guid RequesterId { get; set; }
        public Guid? AssignedTo { get; set; }
        public TicketStatus Status { get; set; } = TicketStatus.Open;
        public TicketPriority Priority { get; set; } = TicketPriority.Low;
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime LastUpdatedAt { get; set; } = DateTime.Now;

    }
}
