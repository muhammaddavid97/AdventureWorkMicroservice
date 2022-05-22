using Persons.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Contracts.Interfaces
{
    public interface IPhoneNumberRepository
    {
        Task<IEnumerable<PersonPhone>> GetAllPhoneNumberAsync(bool trackChanges);
        Task<PersonPhone> GetPhoneNumberAsync(int id, bool trackChanges);
        void CreatePhoneNumberAsync(PersonPhone phone);
        void DeletePhoneNumberAsync(PersonPhone phone);
        void UpdatePhoneNumberAsync(PersonPhone phone);
    }
}
