using AutoMapper;
using SkateCompScoreboard.Core.Entities;

namespace SkateCompScoreboard.Application.Core
{
    public class ProfileMapper : Profile
    {
        public ProfileMapper()
        {
            CreateMap<Competition, Competition>();
        }
    }
}
