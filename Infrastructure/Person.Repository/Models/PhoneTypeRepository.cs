using Microsoft.EntityFrameworkCore;
using Persons.Contracts.Interfaces;
using Persons.Entities.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Repository.Models
{
    public class PhoneTypeRepository : RepositoryBase<PhoneTypeRepository>, IPhoneTypeRepository
    {
        public PhoneTypeRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public Task<IEnumerable<IPhoneTypeRepository>> GetAllPhoneTypeAsync(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<IPhoneTypeRepository> GetPhoneTypeAsync(int id, bool trackChanges)
        {
            throw new NotImplementedException();
        }
    }
}
