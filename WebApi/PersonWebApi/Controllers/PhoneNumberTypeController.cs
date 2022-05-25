using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Person.Contracts;
using Persons.Contracts;
using Persons.Entities.DataTransferObject;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonWebApi.Controllers
{
    [Route("api/phonetype")]
    [ApiController]
    public class PhoneNumberTypeController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public PhoneNumberTypeController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllPhoneNumberType()
        {
            var phoneNumberTypes = await _repository.PhoneNumberType.GetAllPhoneNumberType(trackChanges: false);
            var phoneNumberTypeDTO = _mapper.Map<IEnumerable<PhoneNumberTypeDTO>>(phoneNumberTypes);
            return Ok(phoneNumberTypeDTO);
        }

    }
}
