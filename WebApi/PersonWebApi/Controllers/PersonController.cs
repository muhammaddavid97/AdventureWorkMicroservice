using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Persons.Contracts;
using Persons.Entities.DataTransferObject;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonWebApi.Controllers
{
    [Route("api/person")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "v1")]
    public class PersonController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public PersonController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        /*[HttpGet, Authorize]
        public async Task<IActionResult> GetPerson()
        {
            var person = await _repository.Person.GetAllPersonAsync(trackChanges: false);
            var personDto = _mapper.Map<IEnumerable<PersonDto>>(person);
            return Ok(personDto);
        }*/


    }
}
