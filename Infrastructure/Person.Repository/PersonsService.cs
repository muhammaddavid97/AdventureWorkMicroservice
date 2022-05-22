using Microsoft.AspNetCore.Identity;
using Persons.Contracts;
using Persons.Entities.DataTransferObject;
using Persons.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Repository
{
    public class PersonsService : IServicePerson
    {
        private readonly IRepositoryManager _repository;

        public PersonsService(IRepositoryManager repository, UserManager<User> userManager)
        {
            _repository = repository;
            
        }

        public string CreateSalt()
        {
            var pass = new System.Security.Cryptography.RNGCryptoServiceProvider();
            var length = new byte[4];
            pass.GetBytes(length);
            return Convert.ToBase64String(length);
        }

        public async Task<bool> SignUp(PersonSignUpDto signUpDto)
        {
            BusinessEntity businessEntity = new BusinessEntity();
            Person person = new Person();
            EmailAddress emailAddress = new EmailAddress();
            PersonPhone phone = new PersonPhone();
            Password password = new Password();

            try
            {
                // create business entity
                businessEntity.ModifiedDate = DateTime.Now;
                businessEntity.rowguid = Guid.NewGuid();
                _repository.Business.CreateBusinessEntityAsync(businessEntity);
                await _repository.SaveAsync();

                // Masukin data dari dto ke tabel person
                person.BusinessEntityID = businessEntity.BusinessEntityID;
                person.FirstName = signUpDto.FirstName;
                person.MiddleName = signUpDto.MiddleName;
                person.LastName = signUpDto.LastName;
                person.Suffix = signUpDto.Suffix;
                person.PersonType = signUpDto.PersonType;
                person.ModifiedDate = DateTime.Now;
                person.rowguid = Guid.NewGuid();
                _repository.Person.CreatePersonAsync(person);
                await _repository.SaveAsync();

                emailAddress.BusinessEntityID = businessEntity.BusinessEntityID;
                emailAddress.EmailAddress1 = signUpDto.Email;
                _repository.Email.CreateEmailAsync(emailAddress);
                await _repository.SaveAsync();

                phone.BusinessEntityID = businessEntity.BusinessEntityID;
                phone.PhoneNumber = signUpDto.PhoneNumber;
                phone.PhoneNumberTypeID = signUpDto.PhoneNumberType;
                _repository.PhoneNumber.CreatePhoneNumberAsync(phone);
                await _repository.SaveAsync();
                
                password.BusinessEntityID = businessEntity.BusinessEntityID;
                password.PasswordHash = signUpDto.Password;
                password.PasswordSalt = CreateSalt();
                _repository.Password.CreatePasswordAsync(password);
                _repository.Password.CreatePasswordAsync(password);
                await _repository.SaveAsync();

                return true;
            } 
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
