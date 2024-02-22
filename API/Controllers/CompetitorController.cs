using MediatR;
using Microsoft.AspNetCore.Mvc;
using SkateCompScoreboard.Application.Competitions.Commands;
using SkateCompScoreboard.Core.Entities;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CompetitorController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CompetitorController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<Competition>> GetAll()
        {
            return await _mediator.Send(new ListCommand.Query());
        }

        [HttpGet]
        public async Task<Competition> Find(string id)
        {
            return await _mediator.Send(new DetailCommand.Query());
        }

        [HttpPost]
        public async Task<IActionResult> Create(Competition competition)
        {
            await _mediator.Send(new CreateCommand.Command{ Competition = competition });
            return Ok();
        }

/*        [HttpPut]
        public async Task Edit(Competition competition)
        {
            throw new NotImplementedException();
        }


        [HttpDelete]
        public async Task Delete(Competition competition)
        {
            throw new NotImplementedException();
        }*/


    }
}
