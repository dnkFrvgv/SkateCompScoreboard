using MediatR;
using Microsoft.AspNetCore.Mvc;
using SkateCompScoreboard.Core.Entities;
using SkateCompScoreboard.Application.SingleTrickSections.Features;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SingleTrickSectionController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SingleTrickSectionController(IMediator mediator)
        {
            _mediator = mediator;
        }
        // GET: api/<SingleTrickSectionController>
        [HttpGet]
        public async Task<List<SingleTrickSection>> GetAll()
        {
            return await _mediator.Send(new List.Query());
        }

       /* // GET api/<SingleTrickSectionController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SingleTrickSectionController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SingleTrickSectionController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SingleTrickSectionController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }*/
    }
}
