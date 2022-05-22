using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Persons.Contracts;
using Persons.Entities.DataTransferObject;
using Persons.Entities.Models;
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

        [HttpGet("PersonType")]
        public async Task<IActionResult> GetAllPersonTypeAsync()
        {
            var personType = await _repository.PersonTypesView.GetAllPersonTypeAsync(trackChanges: false);
            var personTypeDto = _mapper.Map<IEnumerable<VPersonTypeDto>>(personType);
            return Ok(personTypeDto);
        }

        [HttpGet("Region")]
        public async Task<IActionResult> GetAllRegionPersonAsync()
        {
            var regionPerson = await _repository.RegionPersonView.GetAllRegionPersonAsync(trackChanges: false);
            var regionPersonDto = _mapper.Map<IEnumerable<VRegionPersonDto>>(regionPerson);
            return Ok(regionPersonDto);
        }
    }
}
