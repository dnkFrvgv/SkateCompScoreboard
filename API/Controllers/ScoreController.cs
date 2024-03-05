using MediatR;
using Microsoft.AspNetCore.Mvc;
using SkateCompScoreboard.Core.Entities;
using SkateCompScoreboard.Application.Scores.Features;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScoreController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ScoreController(IMediator mediator)
        {
            _mediator = mediator;
        }
        // GET: api/<ScoreController>
        [HttpGet]
        public async Task<List<Score>> GetAll()
        {
            return await _mediator.Send(new List.Query());
        }

        /*// GET api/<ScoreController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ScoreController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ScoreController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ScoreController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }*/
    }
}
