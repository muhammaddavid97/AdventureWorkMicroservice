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
    public class AddressRepository : RepositoryBase<Address>, IAddressRepository
    {

        public AddressRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreateAddress(Address address)
        {
            Create(address);
        }

        public void DeleteAddress(Address address)
        {
            Delete(address);
        }

        public async Task<IEnumerable<Address>> GetAllAddress(bool trackChanges) =>
            await FindAll(trackChanges)
                  .OrderBy(c => c.AddressID)
                  .ToListAsync();

        public  async Task<Address> GetAddress(int id, bool trackChanges)
            => await FindByCondition(c => c.AddressID.Equals(id), trackChanges).SingleOrDefaultAsync();

        public void UpdateAddress(Address address)
        {
            Update(address);
        }
    }
}
