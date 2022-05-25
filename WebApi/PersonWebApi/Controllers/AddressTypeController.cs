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
    [Route("api/address_type")]
    [ApiController]
    public class AddressTypeController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public AddressTypeController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]

        public async Task<IActionResult> GetAllAddressType()
        {
            var address = await _repository.AddressType.GetAllAddressType(trackChanges: false);
            var addressDTO = _mapper.Map<IEnumerable<AddressTypeDTO>>(address);
            return Ok(addressDTO);
        }

        [HttpDelete("{id}")] 
        public async Task<IActionResult> DeleteAddressType(int id)
        {
            var address = await _repository.AddressType.GetAddressType(id, trackChanges: false);

            if (address == null)
            {
                _logger.LogInfo($"Customer with id : {id} doesn't exist in database");
                return NotFound();
            }

            _repository.AddressType.DeleteAddressType(address);
            await _repository.saveAsync();
            return NoContent();
        }
    }
}
