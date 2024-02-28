using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SkateCompScoreboard.Application.Rounds.Commands;
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
            return await _mediator.Send(new ListCommand.Query());
        }
    }
}
