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
    [Route("api/person/email")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public EmailController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        /*[HttpGet]
        public async Task<IActionResult> GetAllEmailAsync()
        {
            var email = await _repository.Email.GetAllEmailAsync(trackChanges: false);
            var emailDto = _mapper.Map<IEnumerable<EmailDto>>(email);
            return Ok(emailDto);
        }

        [HttpGet("{id}", Name = "EmailByBusinessEntityId")]
        public async Task<IActionResult> GetEmail(int id)
        {
            var email = await _repository.Email.GetEmailAsync(id, false);

            if (email == null)
            {
                _logger.LogInfo($"Email with Id : {id} not found");
                return NotFound();
            }
            else
            {
                var emailDto = _mapper.Map<EmailDto>(email);
                return Ok(emailDto);
            }
        }

        [HttpPost]
        public async Task<IActionResult> PostEmail([FromBody] EmailDto emailDto)
        {
            if (emailDto == null)
            {
                _logger.LogError("Email is null");
                return BadRequest("Email is null");
            }

            //Object modelState digunakan untuk validasi data yang ditangkap oleh customerdto
            if (!ModelState.IsValid)
            {
                _logger.LogError("Invalid modelstate emailDto");
                return UnprocessableEntity(ModelState);
            }

            var emailEntity = _mapper.Map<EmailAddress>(emailDto);
            _repository.Email.CreateEmailAsync(emailEntity);

            await _repository.SaveAsync();

            var emailResult = _mapper.Map<EmailAddress>(emailEntity);
            return CreatedAtRoute("EmailById", new { id = emailResult.BusinessEntityID }, emailResult);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteEmail(int id)
        {
            var email = await _repository.Email.GetEmailAsync(id, trackChanges: false);
            if (email == null)
            {
                _logger.LogInfo($"Email with id : {id} doesn't exist in database");
                return NotFound();
            }

            _repository.Email.DeleteEmailAsync(email);
            await _repository.SaveAsync();
            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEmail(int id, [FromBody] EmailDto emailDto)
        {
            if (emailDto == null)
            {
                _logger.LogError("Email must not be null");
                return BadRequest("Email must not be null");
            }

            if (!ModelState.IsValid)
            {
                _logger.LogError("Invalid model state for emailDto object");
                return UnprocessableEntity(ModelState);
            }
            var emailEntity = await _repository.Email.GetEmailAsync(id, trackChanges: true);

            if (emailEntity == null)
            {
                _logger.LogError($"Email with id : {id} not found");
                return NotFound();
            }

            _mapper.Map(emailDto, emailEntity);
            //_repository.Customer.UpdateCustomer(customerEntity);
            await _repository.SaveAsync();
            return NoContent();
        }*/
    }
}
