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

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmailById(int id)
        {
            var emailById = await _repository.EmailAddress.GetEmailAddress(id, trackChanges: false);
            if (emailById == null)
            {
                _logger.LogInfo("Profile with Id : " + id + "doesn't exists");
                return NotFound();
            }
            else
            {
                var profilesDTO = _mapper.Map<EmailAddressDTO>(emailById);
                return Ok(profilesDTO);
            }
        }
    }
}
