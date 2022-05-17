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
        Task<EmailAddress> GetEmailAsync(int id, bool trackChanges);
        void CreateEmailAsync(EmailAddress email);
        void DeleteEmailAsync(EmailAddress email);
        void UpdateEmailAsync(EmailAddress email);
    }
}
