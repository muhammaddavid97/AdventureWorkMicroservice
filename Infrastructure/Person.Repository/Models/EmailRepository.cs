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
    public class EmailRepository : RepositoryBase<EmailAddress>, IEmailRepository
    {
        public EmailRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreateEmailAsync(EmailAddress email)
        {
            Create(email);
        }

        public void DeleteEmailAsync(EmailAddress email)
        {
            Delete(email);
        }

        public async Task<IEnumerable<EmailAddress>> GetAllEmailAsync(bool trackChanges)
        {
            return await FindAll(trackChanges)
                    .OrderBy(c => c.EmailAddressID)
                    .ToListAsync();
        }

        public async Task<EmailAddress> GetEmailAsync(int id, bool trackChanges) =>
            await FindByCondition(c => c.EmailAddressID.Equals(id), trackChanges).SingleOrDefaultAsync();

        public void UpdateEmailAsync(EmailAddress email)
        {
            Update(email);
        }
    }
}
