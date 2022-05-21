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
    public class EmailAddressRepository : RepositoryBase<EmailAddress>, IEmailAddressRepository
    {
        public EmailAddressRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreateEmailAddress(EmailAddress emailAddress)
        {
            Create(emailAddress);
        }

        public void DeleteEmailAddress(EmailAddress emailAddress)
        {
            Delete(emailAddress);
        }

        public async Task<EmailAddress> GetEmailAddress(int id, bool trackChanges)
        {
            return await FindByCondition(c => c.EmailAddressID.Equals(id), trackChanges).SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<EmailAddress>> GetAllEmailAddress(bool trackChanges) =>
            await FindAll(trackChanges)
                    .OrderBy(c => c.EmailAddressID)
                    .ToListAsync();

        public void UpdateEmailAddress(EmailAddress emailAddress)
        {
            Update(emailAddress);
        }
    }
}
