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
        private IEmailAddressRepository _emailAddressRepository;
        private IPhoneNumberRepository _phoneNumberRepository;
        private IAddressTypeRepository _addressTypeRepository;
        private IStateProvinceRepository _stateProvinceRepository;
        private IPhoneNumberTypeRepository _phoneNumberTypeRepository;
        private IBusinessEntityAddressRepository _businessEntityAddressRepository;
        private IAddressRepository _addressRepository;
        private IPersonTypeRepository _personTypeRepository;

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

        public IEmailAddressRepository EmailAddress
        {
            get
            {
                if ( _emailAddressRepository == null)
                {
                    _emailAddressRepository = new EmailAddressRepository(_repositoryContext);
                }

                return _emailAddressRepository;
            }
        }

        public IPhoneNumberRepository PersonPhone
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

        public IAddressTypeRepository AddressType
        {
            get
             {
                if (_addressTypeRepository == null)
                {
                    _addressTypeRepository = new AddressTypeIdRepository(_repositoryContext);
                }

                return _addressTypeRepository;
            }
        }

        public IStateProvinceRepository StateProvince
        {
            get
            {
                if (_stateProvinceRepository == null)
                {
                    _stateProvinceRepository = new StateProvinceRepository(_repositoryContext);
                }

                return _stateProvinceRepository;
            }
        }

        public IPhoneNumberTypeRepository PhoneNumberType
        {
            get
            {
                if (_phoneNumberTypeRepository == null)
                {
                    _phoneNumberTypeRepository = new PhoneNumberTypeRepository(_repositoryContext);
                }

                return _phoneNumberTypeRepository; ;
            }
        }

        public IBusinessEntityAddressRepository BusinessEntityAddress
        {
            get
            {
                if (_businessEntityAddressRepository == null)
                {
                    _businessEntityAddressRepository = new BusinessEntityAddressRepository(_repositoryContext);
                }

                return _businessEntityAddressRepository;
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

        public IPersonTypeRepository PersonType
        {
            get
            {
                if (_personTypeRepository == null)
                {
                    _personTypeRepository = new PersonTypeRepository(_repositoryContext);
                }

                return _personTypeRepository;
            }
        }

        public async Task saveAsync() => 
            await _repositoryContext.SaveChangesAsync();
    }
}
