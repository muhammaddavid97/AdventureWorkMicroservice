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

        public async Task PostProfile(int id,ProfileDTO profileDTO)
        {

            try
            {
                var personEntity = await _repositoryManager.Person.GetPerson(id, trackChanges: false);

                if (personEntity == null)
                {
                    _logger.LogError($"Person with id : {id} not found");
                }
            }
            catch (Exception ex)
            {

                _logger.LogError($"Find person error : {id} not found {ex.Message}");
            }
            

            /*Persons.Entities.Models.Person person = new Persons.Entities.Models.Person();

            person.FirstName = profileDTO.FirstName;
            person.MiddleName = profileDTO.MiddleName;
            person.LastName = profileDTO.LastName;
            person.Suffix = profileDTO.Suffix;
            person.BusinessEntityID = profileDTO.BusinessEntityID;*/
           

            //_repositoryManager.Person.UpdatePerson(person);
            //_repositoryManager.saveAsync();
        }
    }
}
