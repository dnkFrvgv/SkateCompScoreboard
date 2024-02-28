using AutoMapper;
using SkateCompScoreboard.Application.Competitions.Dtos;
using SkateCompScoreboard.Core.Entities;

namespace SkateCompScoreboard.Application.Core
{
    public class ProfileMapper : Profile
    {
        public ProfileMapper()
        {
            CreateMap<Competition, Competition>();
            CreateMap<CompetitionRequestDto, Competition>();
            CreateMap<Competition, CompetitionRequestDto>();
        }
    }
}
