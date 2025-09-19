using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tickets.Application.Abstractions.Commands;
using Tickets.Application.Abstractions.Queries;

namespace Tickets.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TicketsController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }


        [HttpPost]
        public async Task<IActionResult> CreateTicket([FromBody] CreateTicketCommand command)
        {
            if (command is null)
                return BadRequest("Invalid Command");

            var ticket = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetTicketById), new { id = ticket.Id }, ticket);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTicketById(Guid id)
        {
            var ticket = await _mediator.Send(new GetTicketByIdQuery(id));
            if (ticket == null)
                return NotFound();

            return Ok(ticket);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTicket(Guid id)
        {
            await _mediator.Send(new DeleteTicketCommand(id));
            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTicket(Guid id, [FromBody] UpdateTicketCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest("Route ID and command ID do not match.");
            }

            var updatedTicket = await _mediator.Send(command);

            return Ok(updatedTicket);
        }
    }
}
