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
            CreateEmailAddress(emailAddress);
        }

        public void DeleteEmailAddress(EmailAddress emailAddress)
        {
            DeleteEmailAddress(emailAddress);
        }

        /*public Task<EmailAddress> GetEmailAddress(int id, bool trackChanges)
        {
            throw new NotImplementedException();
        }*/

        /* public IEnumerable<EmailAddress> GetAll*/

        public void UpdateEmailAddress(EmailAddress emailAddress)
        {
            UpdateEmailAddress(emailAddress);
        }
    }
}
