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
    public class AddressTypeIdRepository : RepositoryBase<AddressType>, IAddressTypeRepository
    {
        public AddressTypeIdRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreateAddressType(AddressType addressType)
        {
            Create(addressType);
        }

        public void DeleteAddressType(AddressType addressType)
        {
            Delete(addressType);
        }

        public async Task<AddressType> GetAddressType(int id, bool trackChanges) =>
            await FindByCondition(c => c.AddressTypeID.Equals(id), trackChanges).SingleOrDefaultAsync();

        public async Task<IEnumerable<AddressType>> GetAllAddressType(bool trackChanges) => 
            await FindAll(trackChanges)
                      .OrderBy(c => c.AddressTypeID)
                      .ToListAsync();

        public void UpdateAddressType(AddressType addressType)
        {
            Update(addressType);
        }
    }
}
