using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Person.Contracts;
using Persons.Contracts;
using Persons.Entities.DataTransferObject;
using Persons.Entities.Models;
using System.Threading.Tasks;

namespace PersonWebApi
{
    [Route("api/authentication")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private readonly IAuthenticationManager _authManager;

        public AuthenticationController(ILoggerManager logger, IMapper mapper, UserManager<User> userManager)
        {
            _logger = logger;
            _mapper = mapper;
            _userManager = userManager;
        }

        [HttpPost]
        public async Task<IActionResult> SignUpProfile([FromBody] PersonModelDTO personModelDTO)
        {
            var profile = _mapper.Map<User>(personModelDTO);
            var results = await _userManager.CreateAsync(profile, personModelDTO.Password);
            if (!results.Succeeded)
            {
                foreach(var error in results.Errors)
                {
                    ModelState.TryAddModelError(error.Code, error.Description);
                }

                return BadRequest(ModelState);
            }

            await _userManager.AddToRolesAsync(profile, personModelDTO.Roles);
            return StatusCode(201);
        }
    }
}
