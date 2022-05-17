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
    public class PasswordRepository : RepositoryBase<Password>, IPasswordRepository
    {
        public PasswordRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreatePasswordAsync(Password password)
        {
            Create(password);
        }

        public void DeletePasswordAsync(Password password)
        {
            Delete(password);
        }

        public async Task<IEnumerable<Password>> GetAllPasswordAsync(bool trackChanges)
        {
            return await FindAll(trackChanges)
                    .OrderBy(c => c.PasswordHash)
                    .ToListAsync();
        }

        public async Task<Password> GetPasswordAsync(int id, bool trackChanges) =>
            await FindByCondition(c => c.BusinessEntityID.Equals(id), trackChanges).SingleOrDefaultAsync();

        public void UpdatePasswordAsync(Password password)
        {
            Update(password);
        }
    }
}
