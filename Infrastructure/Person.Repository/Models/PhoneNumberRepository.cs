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
    public class PhoneNumberRepository : RepositoryBase<PersonPhone>, IPhoneNumberRepository
    {
        public PhoneNumberRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreatePhoneNumberAsync(PersonPhone phone)
        {
            Create(phone);
        }

        public void DeletePhoneNumberAsync(PersonPhone phone)
        {
            Delete(phone);
        }

        public async Task<IEnumerable<PersonPhone>> GetAllPhoneNumberAsync(bool trackChanges)
        {
            return await FindAll(trackChanges)
                    .OrderBy(c => c.BusinessEntityID)
                    .ToListAsync();
        }

        public async Task<PersonPhone> GetPhoneNumberAsync(int id, bool trackChanges) =>
            await FindByCondition(c => c.BusinessEntityID.Equals(id), trackChanges).SingleOrDefaultAsync();

        public void UpdatePhoneNumberAsync(PersonPhone phone)
        {
            Update(phone);
        }
    }
}
