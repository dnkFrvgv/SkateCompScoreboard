using MediatR;
using Microsoft.AspNetCore.Mvc;
using SkateCompScoreboard.Application.LineSections.Features;
using SkateCompScoreboard.Core.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LineSectionController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LineSectionController(IMediator mediator)
        {
            _mediator = mediator;
        }
        // GET: api/<LineSectionController>
        [HttpGet]
        public async Task<List<LineSection>> GetAll()
        {
            return await _mediator.Send(new List.Query());
        }
/*
        // GET api/<LineSectionController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<LineSectionController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<LineSectionController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LineSectionController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }*/
    }
}
