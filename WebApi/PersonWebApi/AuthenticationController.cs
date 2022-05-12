using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Persons.Contracts;
using Persons.Entities.DataTransferObject;
using Persons.Entities.Models;
using System.Threading.Tasks;

namespace PersonWebApi
{
    [Route("api/person")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        // UserManager provide by Identity used for managing user
        private readonly UserManager<User> _userManager;

        public AuthenticationController(ILoggerManager logger, IMapper mapper, UserManager<User> userManager)
        {
            _logger = logger;
            _mapper = mapper;
            _userManager = userManager;
        }

        [HttpPost("signup")]
        public async Task<IActionResult> SignUpPerson([FromBody] PersonSignUpDto personSignUp)
        {
            var user = _mapper.Map<User>(personSignUp);
            // CreateAsync method to create user in database then will save the user to db
            // If action succeed will return message, if it return error, we add to modelState
            // if user created, it will return 201 created

            var result = await _userManager.CreateAsync(user, personSignUp.Password);

            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.TryAddModelError(error.Code, error.Description);
                }
                return BadRequest(ModelState);
            }

            await _userManager.AddToRolesAsync(user, personSignUp.PersonType);
            return StatusCode(201);
        }
    }
}
