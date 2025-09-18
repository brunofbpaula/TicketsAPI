using Tickets.Domain.Enums;
using Tickets.Domain.Primitives;

namespace Tickets.Domain.Entities.Ticket
{
    public class Ticket : Entity
    {
        public Ticket(Guid requesterId, string title, string description)
        : base(Guid.NewGuid())
        {
            RequesterId = requesterId;
            Title = title;
            Description = description;
            Status = TicketStatus.Open;
            Priority = TicketPriority.Low;
            CreatedAt = DateTime.UtcNow;
            LastUpdatedAt = DateTime.UtcNow;
        }

        public Guid RequesterId { get; set; }
        public Guid? AssignedTo { get; set; }
        public TicketStatus Status { get; set; } = TicketStatus.Open;
        public TicketPriority Priority { get; set; } = TicketPriority.Low;
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime LastUpdatedAt { get; set; } = DateTime.Now;

    }
}
