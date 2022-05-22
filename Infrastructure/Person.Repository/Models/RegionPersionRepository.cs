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
    public class RegionPersionRepository : RepositoryBase<VRegionPerson>, IRegionPersonRepository
    {
        public RegionPersionRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public async Task<IEnumerable<VRegionPerson>> GetAllRegionPersonAsync(bool trackChanges)
        {
            return await FindAll(trackChanges)
                        .OrderBy(c => c.Name)
                        .ToListAsync();
        }
    }
}
