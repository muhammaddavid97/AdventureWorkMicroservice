using Persons.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Contracts.Interfaces
{
    public interface IEmailRepository
    {
        Task<IEnumerable<EmailAddress>> GetAllEmailAsync(bool trackChanges);
        Task<EmailAddress> GetEmailAsync(string emailAddress, bool trackChanges);
        Task<EmailAddress> GetEmailByIdAsync(int bussEntityId, bool trackChanges);
        Task<EmailAddress> GetEmailByEmailAsync(string email, bool trackChanges);
        void CreateEmailAsync(EmailAddress email);
        void DeleteEmailAsync(EmailAddress email);
        void UpdateEmailAsync(EmailAddress email);
    }
}
