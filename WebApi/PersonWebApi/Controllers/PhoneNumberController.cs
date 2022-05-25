using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Person.Contracts;
using Persons.Contracts;
using System.Threading.Tasks;

namespace PersonWebApi.Controllers
{
    [Route("api/person_phone")]
    [ApiController]
    public class PhoneNumberController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public PhoneNumberController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpDelete("{numberPhone}")] 

        public async Task<IActionResult> DeletePhoneNumber(string numberPhone)
        {
            var phoneNumbers = await _repository.PersonPhone.GetPersonPhone(numberPhone, trackChanges: false);

            if (phoneNumbers == null)
            {
                _logger.LogInfo($"Phone Number with phone number : {numberPhone} doesn't exist in database");
                return NotFound();
            }

            _repository.PersonPhone.DeletePersonPhone(phoneNumbers);
            await _repository.saveAsync();
            return Ok("Success deleted in database");
        }
    }
}
