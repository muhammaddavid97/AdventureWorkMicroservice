using Microsoft.AspNetCore.Identity;
using Person.Contracts;
using Persons.Contracts;
using Persons.Contracts.interfaces;
using Persons.Entities.DataTransferObject;
using Persons.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Repository.Models
{
    public class ServiceProfile : IServiceProfile
    {

        private readonly IRepositoryManager _repositoryManager;
        private readonly ILoggerManager _logger;

        public ServiceProfile(IRepositoryManager repositoryManager, ILoggerManager logger)
        {
            _repositoryManager = repositoryManager;
            _logger = logger;
        }

        public async Task<bool> PostProfile(int id, ProfileDTO profileDTO)
        {

            var personEntity = await _repositoryManager.Person.GetPerson(id, trackChanges: true);
            personEntity.FirstName = profileDTO.FirstName;
            personEntity.LastName = profileDTO.LastName;
            personEntity.MiddleName = profileDTO.MiddleName;
            personEntity.Suffix = profileDTO.Suffix;

            if (personEntity == null)
            {
                _logger.LogError($"Person with id : {id} not found");
            }

            //_repositoryManager.Person.UpdatePerson(personEntity);
            //await _repositoryManager.saveAsync();

            foreach (var email in profileDTO.Emails)
            {
                try
                {
                    var emailEntity = await _repositoryManager.EmailAddress.GetEmailAddress(email.EmailAddressID, trackChanges: true);
                    // memeriksa kondisi jika EmailAddress tidak ditemukan maka tambah data baru 

                    if (emailEntity == null)
                    {
                        var emailModel = new EmailAddress();

                        emailModel.EmailAddress1 = email.EmailAddress1;
                        emailModel.BusinessEntityID = email.BusinessEntityID;
                        emailModel.EmailAddressID = email.EmailAddressID;

                        _repositoryManager.EmailAddress.CreateEmailAddress(emailModel);

                    }
                    else
                    {
                        emailEntity.EmailAddress1 = email.EmailAddress1;
                        _repositoryManager.EmailAddress.UpdateEmailAddress(emailEntity);
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError($"Error when insert into EmailAddress {ex.Message}");
                }
            }

            await _repositoryManager.saveAsync();


            /*  foreach (var phone in profileDTO.PersonPhones)
              {
                  var phoneEntityById = await _repositoryManager.PersonPhone.GetPersonPhone(id, trackChanges: false);

                  if (phoneEntityById == null)
                  {
                      phoneEntityById.BusinessEntityID = phone.BusinessEntityID;
                      phoneEntityById.PhoneNumber = phone.PhoneNumber;
                      phoneEntityById.PhoneNumberTypeID = phone.PhoneNumberTypeID;
                  }

                  _repositoryManager.PersonPhone.CreatePersonPhone(phoneEntityById);
                 // _repositoryManager.saveAsync();
              }*/

            return true;

        }
    }
}
