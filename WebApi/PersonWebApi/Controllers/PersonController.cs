using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Person.Contracts;
using Persons.Contracts;
using Persons.Contracts.interfaces;
using Persons.Entities.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonWebApi.Controllers
{
    [Route("api/persons")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _loggerManager;
        private readonly IMapper _mapper;

        public PersonController(IRepositoryManager repository, ILoggerManager loggerManager)
        {
            _repository = repository;
            _loggerManager = loggerManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPerson()
        {
            var profiles = await _repository.Person.GetAllPerson(trackChanges : false);
            var profilesDTO = _mapper.Map<IEnumerable<ProfileDTO>>(profiles);
            return Ok(profilesDTO); 
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAllPerson(int id)
        {
            var persons= await _repository.Person.GetPerson(id,trackChanges: false);
            return Ok(persons);
        }

    }
}
