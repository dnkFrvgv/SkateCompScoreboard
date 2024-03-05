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

/*        // GET api/<CompetitorController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CompetitorController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CompetitorController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CompetitorController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }*/
    }
}
