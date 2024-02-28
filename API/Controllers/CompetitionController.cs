using MediatR;
using Microsoft.AspNetCore.Mvc;
using SkateCompScoreboard.Application.Competitions.Commands;
using SkateCompScoreboard.Core.Entities;
using System.Diagnostics;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CompetitionController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CompetitionController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<Competition>> GetAll()
        {
            return await _mediator.Send(new ListCommand.Query());
        }

        [HttpGet("{id}")]
        public async Task<Competition> GetById(Guid id)
        {
            return await _mediator.Send(new DetailCommand.Query { Id = id});
        }

        [HttpPost]
        public async Task<IActionResult> Create(Competition competition)
        {
            return Ok(await _mediator.Send(new CreateCommand.Command{ Competition = competition }));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Edit(Guid id, Competition competition)
        {
            competition.Id = id;

            return Ok(await _mediator.Send(new Edit.Command { Competition = competition}));
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _mediator.Send(new Delete.Command { Id = id });
            return Ok();
        }


    }
}
