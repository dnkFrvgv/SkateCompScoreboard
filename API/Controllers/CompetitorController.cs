using MediatR;
using Microsoft.AspNetCore.Mvc;
using SkateCompScoreboard.Application.Competitors.Features;
using SkateCompScoreboard.Core.Entities;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompetitorController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CompetitorController(IMediator mediator) 
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<Competitor>> GetAll()
        {
            return await _mediator.Send(new List.Query());
        }

        [HttpGet("{id}")]
        public async Task<Competitor> Get(Guid id)
        {
            return await _mediator.Send(new Detail.Query { Id = id });
        }

        [HttpPost]
        public async Task<IActionResult> Post(Competitor competitor)
        {
            await _mediator.Send(new Create.Command { Competitor = competitor });

            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, Competitor competitor)
        {
            competitor.Id = id;

            await _mediator.Send(new Edit.Command { Competitor = competitor });
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _mediator.Send(new Delete.Command { Id = id });
            return Ok();
        }
    }
}
