using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Persons.Contracts;
using Persons.Contracts.Interfaces;
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

        private readonly IAuthenticationManager _authManager;
        
        private readonly ISignUpService _signUp;
        private readonly IRepositoryManager _repositoryManager;

        public AuthenticationController(ILoggerManager logger, IMapper mapper, UserManager<User> userManager, IAuthenticationManager authManager, ISignUpService signUp, IRepositoryManager repositoryManager)
        {
            _logger = logger;
            _mapper = mapper;
            _userManager = userManager;
            _authManager = authManager;
            _signUp = signUp;
            _repositoryManager = repositoryManager;
        }

        [HttpPost("signup")]
        public async Task<IActionResult> SignUpPerson([FromBody] PersonSignUpDto personSignUp)
        {
            var user = _mapper.Map<User>(personSignUp);
            // CreateAsync method to create user in database then will save the user to db
            // If action succeed will return message, if it return error, we add to modelState
            // if user created, it will return 201 created

            var createUser = await _userManager.CreateAsync(user, personSignUp.Password);
            
            var dataSignUp = await _signUp.SignUp(personSignUp);

            if (!createUser.Succeeded)
            {
                foreach (var error in createUser.Errors)
                {
                    ModelState.TryAddModelError(error.Code, error.Description);
                }
                return BadRequest(ModelState);
            }
            
            return StatusCode(201);
        }

        [HttpPost("signin")]
        public async Task<IActionResult> Authenticate([FromBody] PersonSignInDto person)
        {
            var dataSignIn = await _userManager.FindByNameAsync(person.UserName);
            //var dataId = await _userManager.FindByIdAsync();
            if (!await _authManager.ValidateUser(person))
            {
                _logger.LogWarn($"{ nameof(Authenticate)} : Authentication failed. Wrong username or password");
                return Unauthorized();
            }

            return Ok(new { Token = await _authManager.CreateToken(), dataSignIn.Id, dataSignIn.FirstName, dataSignIn.LastName, dataSignIn.UserName, dataSignIn.Email});
        }
    }
}
