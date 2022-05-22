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
    public class BEntityAddressRepository : RepositoryBase<BusinessEntityAddress>, IBeAddressRepository
    {
        public BEntityAddressRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreateEmailAsync(BusinessEntityAddress beAddress)
        {
            Create(beAddress);
        }

        public void DeleteEmailAsync(BusinessEntityAddress beAddress)
        {
            Delete(beAddress);
        }

        public async Task<IEnumerable<BusinessEntityAddress>> GetAllBeAddressAsync(bool trackChanges)
        {
            return await FindAll(trackChanges)
                    .OrderBy(c => c.BusinessEntityID)
                    .ToListAsync();
        }

        public async Task<BusinessEntityAddress> GetBeAddressAsync(int beId, bool trackChanges) =>
            await FindByCondition(c => c.BusinessEntityID.Equals(beId), trackChanges).SingleOrDefaultAsync();

        public void UpdateEmailAsync(BusinessEntityAddress beAddress)
        {
            Update(beAddress);
        }
    }
}
