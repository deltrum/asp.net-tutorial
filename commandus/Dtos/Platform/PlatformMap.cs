using AutoMapper;
using server.Models;

namespace server.Dtos
{
    public class PlatformMap : Profile
    {
        public PlatformMap()
        {
            CreateMap<Platform, PlatformDto>();
            CreateMap<PlatformCreateDto, Platform>();
        }
    }
}