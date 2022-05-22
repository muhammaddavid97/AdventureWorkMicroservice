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
    public class PersonTypeRepository : RepositoryBase<VPersonType>, IPersonTypeRepository
    {
        public PersonTypeRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public async Task<IEnumerable<VPersonType>> GetAllPersonTypeAsync(bool trackChanges)
        {
            return await FindAll(trackChanges)
                    .OrderBy(c => c.PersonType)
                    .ToListAsync();
        }
    }
}
