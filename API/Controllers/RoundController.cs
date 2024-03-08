using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SkateCompScoreboard.Application.Rounds.Features;
using SkateCompScoreboard.Core.Entities;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoundController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RoundController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<Round>> GetAll()
        {
            return await _mediator.Send(new List.Query());
        }

        [HttpGet("{id}")]
        public async Task<Round> GetById(Guid id)
        {
            return await _mediator.Send(new Detail.Query { Id = id });
        }


        [HttpPost]
        public async Task<IActionResult> Create(Round round)
        {
            return Ok(await _mediator.Send(new Create.Command { Round = round }));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Edit(Guid id, Round round)
        {
            round.Id = id;

            return Ok(await _mediator.Send(new Edit.Command { Round = round }));
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _mediator.Send(new Delete.Command { Id = id });

            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<List<RoundCompetitor>> Competitors(Guid roundId)
        {
            return await _mediator.Send(new ListCompetitorsOfRound.Query { RoundId = roundId });
        }
    }
}
