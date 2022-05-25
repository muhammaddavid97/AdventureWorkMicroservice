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
    public class BusinessEntityAddressRepository : RepositoryBase<BusinessEntityAddress>, IBusinessEntityAddressRepository
    {
        public BusinessEntityAddressRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreateBusinessEntityAddress(BusinessEntityAddress businessEntityAddress)
        {
            Create(businessEntityAddress);
        }

        public void DeleteBusinessEntityAddress(BusinessEntityAddress businessEntityAddress)
        {
            Delete(businessEntityAddress);
        }

        public async Task<IEnumerable<BusinessEntityAddress>> GetAllBusinessEntityAddress(bool trackChanges) =>
            await FindAll(trackChanges)
                  .OrderBy(c => c.BusinessEntityID)
                   .ToListAsync();

        public async Task<BusinessEntityAddress> GetBusinessEntityAddress(int id, bool trackChanges) =>
            await FindByCondition(c => c.BusinessEntityID.Equals(id), trackChanges).SingleOrDefaultAsync();

        public void UpdateBusinessEntityAddress(BusinessEntityAddress businessEntityAddress)
        {
           
        }
    }
}
