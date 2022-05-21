using Persons.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persons.Entities.Models;

namespace Persons.Contracts.interfaces
{
    public interface IEmailAddressRepository
    {

        Task<IEnumerable<EmailAddress>> GetAllEmailAddress(bool trackChanges);
        Task<EmailAddress> GetEmailAddress(int id, bool trackChanges);
        void CreateEmailAddress(EmailAddress emailAddress);
        void DeleteEmailAddress(EmailAddress emailAddress);
        void UpdateEmailAddress(EmailAddress emailAddress);

    }
}
