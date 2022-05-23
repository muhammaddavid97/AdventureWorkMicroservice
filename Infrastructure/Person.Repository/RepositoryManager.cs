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
        private IBeAddressRepository _bEntityAddressRepository;
        private IEmailRepository _emailRepository;
        private IPhoneNumberRepository _phoneNumberRepository;
        private IPhoneTypeRepository _phoneTypeRepository;
        private IPasswordRepository _passwordRepository;
        private IPersonTypeRepository _personTypeRepository;
        private IRegionPersonRepository _regionPersonRepository;
        private IStateProvinceRepository _stateProvinceRepository;
        

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

        public IBeAddressRepository BeAddress
        {
            get
            {
                if (_bEntityAddressRepository == null)
                {
                    _bEntityAddressRepository = new BEntityAddressRepository(_repositoryContext);
                }
                return _bEntityAddressRepository;
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

        public IPhoneTypeRepository PhoneType
        {
            get
            {
                if (_phoneTypeRepository == null)
                {
                    _phoneTypeRepository = new PhoneTypeRepository(_repositoryContext);
                }
                return _phoneTypeRepository;
            }
        }

        public IPasswordRepository Password
        {
            get
            {
                if (_passwordRepository == null)
                {
                    _passwordRepository = new PasswordRepository(_repositoryContext);
                }
                return _passwordRepository;
            }
        }

        public IPersonTypeRepository PersonTypesView
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

        public IRegionPersonRepository RegionPersonView
        {
            get
            {
                if (_regionPersonRepository == null)
                {
                    _regionPersonRepository = new RegionPersionRepository(_repositoryContext);
                }
                return _regionPersonRepository;
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
