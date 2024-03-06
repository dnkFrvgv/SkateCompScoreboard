using AutoMapper;
using SkateCompScoreboard.Application.Competitions.Dtos;
using SkateCompScoreboard.Core.Entities;

namespace SkateCompScoreboard.Application.Core
{
    public class ProfileMapper : Profile
    {
        public ProfileMapper()
        {
            // competition
            CreateMap<Competition, Competition>();
            CreateMap<CompetitionRequestDto, Competition>();
            CreateMap<Competition, CompetitionRequestDto>();

            // competitor
            CreateMap<Competitor, Competitor>();

            // line section 
            CreateMap<LineSection, LineSection>();

            // round
            CreateMap<Round, Round>();

        }
    }
}
