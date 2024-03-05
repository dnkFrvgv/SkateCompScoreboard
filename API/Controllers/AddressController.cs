using MediatR;
using Microsoft.AspNetCore.Mvc;
using SkateCompScoreboard.Application.Addresses.Features;
using SkateCompScoreboard.Core.Entities;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AddressController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<Address>> GetAll()
        {
            return await _mediator.Send(new List.Query());
        }
    }
}
