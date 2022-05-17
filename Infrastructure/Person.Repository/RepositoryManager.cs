using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persons.Contracts;
using Persons.Contracts.Interfaces;
using Persons.Entities.Contexts;
using Persons.Repository.Models;

namespace Persons.Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private RepositoryContext _repositoryContext;
        private IPersonRepository _personRepository;
        private IAddressRepository _addressRepository;
        private IBusinessEntityRepository _businessEntityRepository;
        private IEmailRepository _emailRepository;
        private IPhoneNumberRepository _phoneNumberRepository;
        private IPasswordRepository _passwordrepository;

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

        public IAddressRepository Address
        {
            get
            {
                if (_addressRepository == null)
                {
                    _addressRepository = new AddressRepository(_repositoryContext);
                }
                return _addressRepository;
            }
        }

        public IBusinessEntityRepository Business
        {
            get
            {
                if (_businessEntityRepository == null)
                {
                    _businessEntityRepository = new BusinessEntityRepository(_repositoryContext);
                }
                return _businessEntityRepository;
            }
        }

        public IEmailRepository Email
        {
            get
            {
                if (_emailRepository == null)
                {
                    _emailRepository = new EmailRepository(_repositoryContext);
                }
                return _emailRepository;
            }
        }

        public IPhoneNumberRepository PhoneNumber
        {
            get
            {
                if (_phoneNumberRepository == null)
                {
                    _phoneNumberRepository = new PhoneNumberRepository(_repositoryContext);
                }
                return _phoneNumberRepository;
            }
        }

        public IPasswordRepository Password
        {
            get
            {
                if (_passwordrepository == null)
                {
                    _passwordrepository = new PasswordRepository(_repositoryContext);
                }
                return _passwordrepository;
            }
        }

        public void Save()
        {
            _repositoryContext.SaveChanges();
        }

        public async Task SaveAsync()
        {
            await _repositoryContext.SaveChangesAsync();
        }
    }
}
