using Microsoft.EntityFrameworkCore;
using Persons.Contracts.interfaces;
using Persons.Entities.Models;
using Persons.Entities.RepositoryContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Repository.Models
{
    public class PhoneNumberTypeRepository : RepositoryBase<PhoneNumberType>, IPhoneNumberTypeRepository
    {
        public PhoneNumberTypeRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreatePhoneNumberType(PhoneNumberType phoneNumberType)
        {
            Create(phoneNumberType);   
        }

        public void DeletePhoneNumberType(PhoneNumberType phoneNumberType)
        {
            Delete(phoneNumberType);
        }

        public async Task<IEnumerable<PhoneNumberType>> GetAllPhoneNumberType(bool trackChanges) =>
            await FindAll(trackChanges)
                  .OrderBy(c => c.PhoneNumberTypeID)
                  .ToListAsync();

        public async Task<PhoneNumberType> GetPhoneNumberType(int id, bool trackChanges) => 
            await FindByCondition(c => c.PhoneNumberTypeID.Equals(id), trackChanges).SingleOrDefaultAsync();

        public void UpdatePhoneNumberType(PhoneNumberType phoneNumberType)
        {
            Update(phoneNumberType);
        }
    }
}
