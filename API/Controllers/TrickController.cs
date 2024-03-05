using MediatR;
using Microsoft.AspNetCore.Mvc;
using SkateCompScoreboard.Application.Tricks.Features;
using SkateCompScoreboard.Core.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrickController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TrickController(IMediator mediator)
        {
            _mediator = mediator;
        }
        // GET: api/<TrickController>
        [HttpGet]
        public async Task<List<Trick>> GetAll()
        {
            return await _mediator.Send(new List.Query());
        }
    }
}
