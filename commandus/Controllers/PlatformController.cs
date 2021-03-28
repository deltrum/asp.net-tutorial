using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using server.Dtos;
using server.Models;
using server.Services;

namespace server.Controllers
{
    [Route("api/platforms")]
    [ApiController]
    public class PlatformController : ControllerBase
    {
        private readonly IPlatformService _platformSvc;

        private readonly IMapper _mapper;

        public PlatformController(IPlatformService platformService, IMapper mapper)
        {
            _platformSvc = platformService;
            _mapper = mapper;
        }

        //! Routes / Requests
        [HttpPost]
        public ActionResult<Platform> CreatePlatform(PlatformCreateDto platformCreateDto)
        {
            var platformModel = _mapper.Map<Platform>(platformCreateDto);

            _platformSvc.Create(platformModel);
            _platformSvc.SaveChanges();

            var platformDto = _mapper.Map<Platform>(platformModel);

            return Ok(platformDto);
        }

        [HttpDelete("{id}")]
        public ActionResult DeletePlatform(int id)
        {
            var platform = _platformSvc.GetOne(id);

            if (platform == null)
            {
                return NotFound();
            }

            _platformSvc.Delete(platform);

            _platformSvc.SaveChanges();

            return NoContent();
        }

        [HttpGet]
        public ActionResult<IList<Platform>> GetAllPlatforms()
        {
            var platforms = _platformSvc.GetAll();

            if (platforms != null)
            {
                return Ok(_mapper.Map<IList<PlatformDto>>(platforms));
            }

            return NotFound();
        }


        [HttpGet("{id}")]
        public ActionResult<Platform> GetOnePlatform(int id)
        {
            var platform = _platformSvc.GetOne(id);

            if (platform != null)
            {
                return Ok(_mapper.Map<PlatformDto>(platform));
            }

            return NotFound();
        }

    }
}