using Persons.Contracts;
using Persons.Contracts.interfaces;
using Persons.Entities.RepositoryContexts;
using Persons.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private RepositoryContext _repositoryContext;
        private IPersonRepository _personRepository;
        private IProfileRepository _profileRepository;
      /*  private IEmailAddressRepository _emailAddressRepository;
        private IPhoneNumberRepository _phoneNumberRepository;*/

        public RepositoryManager(RepositoryContext repositoryContext)
        {
           _repositoryContext = repositoryContext;
        }

        public IPersonRepository Person
        {
            get
            {
                if (_personRepository == null)
                {
                    _personRepository = new PersonRepository(_repositoryContext);
                }

                return _personRepository;
            }
        }

        public IProfileRepository Profile
        {
            get
            {
                if (_personRepository == null)
                {
                    _profileRepository = new ProfileRepository(_repositoryContext);
                }

                return _profileRepository;
            }
        }

      /*  public IEmailAddressRepository EmailAddress
        {
            get
            {
                if (_personRepository == null)
                {
                    _emailAddressRepository = new EmailAddressRepository(_repositoryContext); 
                }

                return _emailAddressRepository;
            }
        }

        public IPhoneNumberRepository PhoneNumber
        {
            get
            {
                if (_phoneNumberRepository == null)
                {
                    _phoneNumberRepository =  new PhoneNumberRepository(_repositoryContext);
                }

                return _phoneNumberRepository;
            }
        }
*/
        public async Task saveAsync() => 
            await _repositoryContext.SaveChangesAsync();
    }
}
