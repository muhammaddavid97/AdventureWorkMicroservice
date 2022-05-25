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

        public async Task<Persons.Entities.Models.Person> PostProfile(int id, ProfileDTO profileDTO)
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

            _repositoryManager.Person.UpdatePerson(personEntity);
            //await _repositoryManager.saveAsync();

            foreach (var email in profileDTO.Emails)
            {
                try
                {
                    // menampilkan data pada model EmailAddress sesuai dengan nilai EmailAddressID
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

                    // jika EmailAddress ditemukan maka lakukan update daata baru
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

            // await _repositoryManager.saveAsync();

            // create data baru pada table PersonNumber

            foreach (var phones in profileDTO.PersonPhones)
            {
                var createPhone = new PersonPhone();

                createPhone.BusinessEntityID = phones.BusinessEntityID;
                createPhone.PhoneNumber = phones.PhoneNumber;
                createPhone.PhoneNumberTypeID = phones.PhoneNumberTypeID;

                if (createPhone.BusinessEntityID == phones.BusinessEntityID && createPhone.PhoneNumber == phones.PhoneNumber && createPhone.PhoneNumberTypeID == phones.PhoneNumberTypeID)
                {
                    _logger.LogError($"data sudah di simpan di database");
                }

                _repositoryManager.PersonPhone.CreatePersonPhone(createPhone);
            }

           //await _repositoryManager.saveAsync();

            await _repositoryManager.saveAsync();

            return personEntity;

        }
    }
}
