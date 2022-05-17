using Microsoft.EntityFrameworkCore;
using Persons.Contracts.Interfaces;
using Persons.Entities.Contexts;
using Persons.Entities.Models;
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

        public void CreateAddressAsync(Address address)
        {
            Create(address);
        }

        public void DeleteAddressAsync(Address address)
        {
            Delete(address);
        }

        public async Task<Address> GetAddressAsync(int id, bool trackChanges) =>
            await FindByCondition(c => c.AddressID.Equals(id), trackChanges).SingleOrDefaultAsync();


        public async Task<IEnumerable<Address>> GetAllAddressAsync(bool trackChanges)
        {
            return await FindAll(trackChanges)
                    .OrderBy(c => c.AddressID)
                    .ToListAsync();
        }
        
        public void UpdateAddressrAsync(Address address)
        {
            Update(address);
        }
    }
}
