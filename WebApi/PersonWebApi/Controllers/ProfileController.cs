using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Person.Contracts;
using Persons.Contracts;
using Persons.Contracts.interfaces;
using Persons.Entities.DataTransferObject;
using System;
using System.Threading.Tasks;

namespace PersonWebApi.Controllers
{
    [Route("api/profile")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        private readonly IServiceProfile _serviceProfile;

        public ProfileController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper, IServiceProfile serviceProfile)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
            _serviceProfile = serviceProfile;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProfileById(int id)
        {
            var profiles = await _repository.Person.GetPerson(id, trackChanges: false);

            if (profiles == null)
            {
                _logger.LogInfo("Profile with Id : " + id + "does'nt exists");
                return NotFound();
            }
            else
            {
                var profilesDTO = _mapper.Map<ProfileDTO>(profiles);
                return Ok(profilesDTO);
            }

        }

        [HttpPost("{id}")]
        public async Task<IActionResult> CreateProfile([FromBody] ProfileDTO profileDTO,int id)
        {
                if (profileDTO == null)
                {
                    _logger.LogError("Category object is null");
                    return BadRequest("Category object is null");
                }

            
            
            var result = await _serviceProfile.PostProfile(id, profileDTO);
          

            if (result)
            {
                return Ok();
            }
            else
            {
                return BadRequest($"unable to post data");
            }

        }

        [HttpPut("{id}")]

        public async Task<IActionResult> UpdateProfile(int id, [FromBody] ProfileDTO profileDTO)
        {
            if (profileDTO == null)
            {
                _logger.LogError($"Category must not be null");
                return BadRequest("Category must not be null");
            }

            // find profile by id
            var profileEntity = await _repository.Profile.GetProfile(id, trackChanges: true);

            return Ok(profileEntity);
           /* if (profileEntity == null)
            {
                _logger.LogInfo($"Category with id : {id} not found");
                return NotFound();
            }

            _mapper.Map(profileDTO, profileEntity);
            // _repository.Category.UpdateCategory(categoryEntity);

            _repository.saveAsync();
            return NoContent();*/
        }
    }
}
