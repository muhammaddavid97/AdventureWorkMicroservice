using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Person.Contracts;
using Persons.Contracts;
using Persons.Entities.DataTransferObject;
using System.Threading.Tasks;

namespace PersonWebApi.Controllers
{
    [Route("api/email_address")]
    [ApiController]
    public class EmailAddressController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public EmailAddressController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> DeleteEmailAddress(int id)
        {
            var emailAddress = await _repository.EmailAddress.GetEmailAddress(id, trackChanges: false);

            if (emailAddress == null)
            {
                _logger.LogInfo($"Customer with id : {id} doesn't exist in database");
                return NotFound();
            }

            _repository.EmailAddress.DeleteEmailAddress(emailAddress);
            await _repository.saveAsync();
            return Ok("Sukses deleted in database");

        }
    } 
}
