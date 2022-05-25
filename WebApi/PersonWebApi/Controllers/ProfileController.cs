using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Person.Contracts;
using Persons.Contracts;
using Persons.Contracts.interfaces;
using Persons.Entities.DataTransferObject;
using System;
using System.Collections;
using System.Collections.Generic;
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

        [HttpGet("{profileId}", Name = "profileById")]
        public async Task<IActionResult> GetProfileById(int profileId)
        {
            var profiles = await _repository.Person.GetPerson(profileId, trackChanges: false);

            if (profiles == null)
            {
                _logger.LogInfo("Profile with Id : " + profileId + "does'nt exists");
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
            
            return CreatedAtRoute("profileById", new { profileId = id }, result);

        }
    }
}
