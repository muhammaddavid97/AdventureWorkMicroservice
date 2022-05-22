using Microsoft.EntityFrameworkCore;
using Persons.Contracts.Interfaces;
using Persons.Entities.Contexts;
using Persons.Entities.DataTransferObject;
using Persons.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Repository.Models
{
    internal class BusinessEntityRepository : RepositoryBase<BusinessEntity>, IBusinessEntityRepository
    {
        public BusinessEntityRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreateBusinessEntityAsync(BusinessEntity be)
        {
            Create(be);
        }

        public void DeleteBusinessEntityAsync(BusinessEntity be)
        {
            Delete(be);
        }

        public async Task<IEnumerable<BusinessEntity>> GetAllBusinessEntityAsync(bool trackChanges)
        {
            return await FindAll(trackChanges)
                    .OrderBy(c => c.BusinessEntityID)
                    .ToListAsync();
        }

        public async Task<BusinessEntity> GetBusinessEntityAsync(int id, bool trackChanges) =>
            await FindByCondition(c => c.BusinessEntityID.Equals(id), trackChanges).SingleOrDefaultAsync();

        public void UpdateBusinessEntityAsync(BusinessEntity be)
        {
            Update(be);
        }
    }
}
