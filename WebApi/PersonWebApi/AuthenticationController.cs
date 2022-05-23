using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Persons.Contracts;
using Persons.Contracts.Interfaces;
using Persons.Entities.DataTransferObject;
using Persons.Entities.Models;
using System;
using System.Linq;
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
        private readonly IServicePerson _servicePerson;
        private readonly IRepositoryManager _repositoryManager;

        public AuthenticationController(ILoggerManager logger, IMapper mapper, UserManager<User> userManager, IAuthenticationManager authManager, IServicePerson servicePerson, IRepositoryManager repositoryManager)
        {
            _logger = logger;
            _mapper = mapper;
            _userManager = userManager;
            _authManager = authManager;
            _servicePerson = servicePerson;
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

            // Validare saat create user success atau engga
            if (!createUser.Succeeded)
            {
                foreach (var error in createUser.Errors)
                {
                    ModelState.TryAddModelError(error.Code, error.Description);
                }
                return BadRequest(ModelState);
            }

            // Update isi password dto
            personSignUp.Password = user.PasswordHash;

            var dataSignUp = await _servicePerson.SignUp(personSignUp);

            return StatusCode(201);
        }

        [HttpPost("signin")]
        public async Task<IActionResult> Authenticate([FromBody] PersonSignInDto person)
        {
            
            try
            {
                var dataSignIn = await _userManager.FindByNameAsync(person.UserName);
                var objPerson = await _repositoryManager.Email.GetEmailByEmailAsync(dataSignIn.Email, trackChanges: false);

                if (!await _authManager.ValidateUser(person))
                {
                    _logger.LogWarn($"{ nameof(Authenticate)} : Authentication failed. Wrong username or password");
                    return Unauthorized();
                }

                return Ok(new { Token = await _authManager.CreateToken(),objPerson.BusinessEntityID, dataSignIn.FirstName, dataSignIn.LastName, dataSignIn.UserName, dataSignIn.Email});
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
