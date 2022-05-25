using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Person.Contracts;
using Persons.Contracts;
using Persons.Entities.DataTransferObject;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonWebApi.Controllers
{
    [Route("api/person/dashboard")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public DashboardController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]

        public async Task<IActionResult> GetAllPersonType()
        {
            var personType = await _repository.PersonType.GetAllPersonType(trackChanges: false);
            var personTypeDto = _mapper.Map<IEnumerable<PersonTypeDTO>>(personType);

            return Ok(personTypeDto);
        }
    }
}
