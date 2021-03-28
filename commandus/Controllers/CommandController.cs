using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using server.Dtos;
using server.Models;
using server.Services;

namespace server.Controllers
{
    [Route("api/cmds")]
    [ApiController]
    public class CommandController : ControllerBase
    {
        private readonly ICommandService _cmdSvc;
        private readonly IMapper _mapper;

        public CommandController(ICommandService cmdSvc, IMapper mapper)
        {
            _cmdSvc = cmdSvc;
            _mapper = mapper;
        }

        //! Routes / Requests
        [HttpPost]
        public ActionResult<Command> CreateCmd(CommandCreateDto cmdCreateDto)
        {
            var cmdModel = _mapper.Map<Command>(cmdCreateDto);

            _cmdSvc.Create(cmdModel);
            _cmdSvc.SaveChanges();

            var cmdDto = _mapper.Map<Command>(cmdModel);

            return Ok(cmdDto);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteCmd(int id)
        {
            var cmd = _cmdSvc.GetOne(id);

            if (cmd == null)
            {
                return NotFound();
            }

            _cmdSvc.Delete(cmd);

            _cmdSvc.SaveChanges();

            return NoContent();
        }

        [HttpGet]
        public ActionResult<IList<Command>> GetAllCmds()
        {
            var cmds = _cmdSvc.GetAll();

            if (cmds != null)
            {
                return Ok(_mapper.Map<IList<CommandDto>>(cmds));
            }

            return NotFound();
        }


        [HttpGet("{id}")]
        public ActionResult<Command> GetOneCmd(int id)
        {
            var cmd = _cmdSvc.GetOne(id);

            if (cmd != null)
            {
                return Ok(_mapper.Map<CommandDto>(cmd));
            }

            return NotFound();
        }

    }
}