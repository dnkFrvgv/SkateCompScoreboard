using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using SkateCompScoreboard.Application.Competitions.Dtos;
using SkateCompScoreboard.Application.Competitions.Features;
using SkateCompScoreboard.Core.Entities;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompetitionController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public CompetitionController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<List<Competition>> GetAll()
        {
            return await _mediator.Send(new List.Query());
        }

        [HttpGet("{id}")]
        public async Task<Competition> GetById(Guid id)
        {
            return await _mediator.Send(new DetailCommand.Query { Id = id});
        }

        [HttpPost]
        public async Task<IActionResult> Create(CompetitionRequestDto competitionDto)
        {
            var competition = _mapper.Map<Competition>(competitionDto);

            await _mediator.Send(new Create.Command { Competition = competition });
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Edit(Guid id, CompetitionRequestDto competitionDto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var competition = _mapper.Map<Competition>(competitionDto);
            
            competition.Id = id;

            await _mediator.Send(new Edit.Command { Competition = competition });

            return Ok();
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _mediator.Send(new Delete.Command { Id = id });
            return Ok();
        }

        [Route("/Rounds")]
        [HttpGet("{id}")]
        public async Task<List<Round>> GetRounds(Guid competitionId)
        {
            return await _mediator.Send(new ListRoundsOfCompetition.Query { CompetitionId = competitionId });
        }

        [Route("/Competitors")]
        [HttpGet("{id}")]
        public async Task<List<RoundCompetitor>> GetCompetitors(Guid competitionId)
        {
            return await _mediator.Send(new ListCompetitorsOfCompetition.Query { CompetitionId = competitionId });
        }

    }
}
