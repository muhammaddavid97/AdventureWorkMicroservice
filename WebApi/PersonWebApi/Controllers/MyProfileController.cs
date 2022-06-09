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
    [Route("api/person/MyProfile/[action]")]
    [ApiController]
    public class MyProfileController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        private readonly IProfileService _profileService;

        public MyProfileController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper, IProfileService profileService)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
            _profileService = profileService;
        }

        [HttpPost("SaveAll")]
        public async Task<IActionResult> SaveAllDataProfile(int bussEntityId, [FromBody] PersonMyProfileDto profileDto)
        {
            if (profileDto == null)
            {
                _logger.LogError("Data Profile is null");
                return BadRequest("Data Profile is null");
            }

            //Object modelState digunakan untuk validasi data yang ditangkap oleh customerdto
            if (!ModelState.IsValid)
            {
                _logger.LogError("Invalid modelstate profile");
                return UnprocessableEntity(ModelState);
            }

            var dataProfile = await _profileService.SaveAll(bussEntityId, profileDto);
            await _repository.SaveAsync();
            return Ok(profileDto);
        }

        /*[HttpGet("{id}", Name = "EmailByBusinessEntityId")]
        public async Task<IActionResult> GetEmail(int id)
        {
            var email = await _profileService.GetEmailByEmailAsync(id);

            if (email == null)
            {
                _logger.LogInfo($"Email with BusinessEntityID : {id} not found");
                return NotFound();
            }
            else
            {
                var emailDto = _mapper.Map<IEnumerable<EmailDto>>(email);
                return Ok(emailDto);
            }
        }

        [HttpGet("{id}", Name = "PhoneByBusinessEntityId")]
        public async Task<IActionResult> GetPhoneNumber(int id)
        {
            var phone = await _profileService.GetPhoneNumberByBEIdAsync(id);

            if (phone == null)
            {
                _logger.LogInfo($"Phone number with BusinessEntityID : {id} not found");
                return NotFound();
            }
            else
            {
                var phoneDto = _mapper.Map<IEnumerable<PhoneNumberDto>>(phone);
                return Ok(phoneDto);
            }
        }

        [HttpGet("{id}", Name = "AddressTypeByBusinessEntityId")]
        public async Task<IActionResult> GetAddressType(int id)
        {
            var addressType = await _profileService.GetAddressTypeByBEIdAsync(id);

            if (addressType == null)
            {
                _logger.LogInfo($"Address Type with BusinessEntityID : {id} not found");
                return NotFound();
            }
            else
            {
                var addressTypeDto = _mapper.Map<IEnumerable<BusinessEntityAddressDto>>(addressType);
                return Ok(addressTypeDto);
            }
        }

        [HttpGet("{id}", Name = "CountryRegionByStateProvinceId")]
        public async Task<IActionResult> GetCountryRegion(int id)
        {
            var countryRegion = await _profileService.GetStateProvinceByBEIdAsync(id);

            if (countryRegion == null)
            {
                _logger.LogInfo($"Country Region with StateProvinceID : {id} not found");
                return NotFound();
            }
            else
            {
                var countryRegionDto = _mapper.Map<IEnumerable<StateProvinceDto>>(countryRegion);
                return Ok(countryRegionDto);
            }
        }

        [HttpGet("{id}", Name = "AddressByAddressId")]
        public async Task<IActionResult> GetAddress(int id)
        {
            var address = await _profileService.GetAddressByBEIdAsync(id);

            if (address == null)
            {
                _logger.LogInfo($"Address with AddressID : {id} not found");
                return NotFound();
            }
            else
            {
                var addressDto = _mapper.Map<IEnumerable<AddressDto>>(address);
                return Ok(addressDto);
            }
        }*/

        /*[HttpPost]
        public async Task<IActionResult> PostNewProfile([FromBody] PersonMyProfileDto myProfile)
        {
            if (myProfile == null)
            {
                _logger.LogError("Profile Data is null");
                return BadRequest("Profile Data is null");
            }

            //Object modelState digunakan untuk validasi data yang ditangkap oleh customerdto
            if (!ModelState.IsValid)
            {
                _logger.LogError("Invalid modelstate My Profile Dto");
                return UnprocessableEntity(ModelState);
            }

            //var myProfileEntity = _mapper.Map<Person>(myProfileDto);
            //_repository.Person.CreatePersonAsync(myProfileEntity);

            var postProfile = await _servicePerson.NewProfile(myProfile);

            await _repository.SaveAsync();

            //var customerResult = _mapper.Map<Customer>(customerEntity);
            //return CreatedAtRoute("CustomerById", new { id = customerResult.CustomerId }, customerResult);
            return CreatedAtRoute("PersonData", postProfile);
        }*/

        /*[HttpPut("{id}")]
        public async Task<IActionResult> UpdateMyProfile(int id, [FromBody] PersonMyProfileDto myProfileDto)
        {
            if (myProfileDto == null)
            {
                _logger.LogError("Data  must not be null");
                return BadRequest("Customer must not be null");
            }

            if (!ModelState.IsValid)
            {
                _logger.LogError("Invalid model state for My Profile Dto object");
                return UnprocessableEntity(ModelState);
            }

            var personEntity = await _repository.Person.GetPersonAsync(id, trackChanges: true);

            if (personEntity == null)
            {
                _logger.LogError($"Profile person with BusinessEntityID : {id} not found");
                return NotFound();
            }

            //_mapper.Map(customerDto, customerEntity);
            //_repository.Customer.UpdateCustomer(customerEntity);
            await _repository.SaveAsync();
            return NoContent();
        }*/


    }
}
