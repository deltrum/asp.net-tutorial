using AutoMapper;
using server.Models;

namespace server.Dtos
{
    public class CommandMap : Profile
    {
        public CommandMap()
        {
            CreateMap<Command, CommandDto>();
            CreateMap<CommandCreateDto, Command>();
        }
    }
}