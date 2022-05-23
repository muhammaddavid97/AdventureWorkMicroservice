using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Contracts.Interfaces
{
    public interface IPhoneTypeRepository
    {
        Task<IEnumerable<IPhoneTypeRepository>> GetAllPhoneTypeAsync(bool trackChanges);
        Task<IPhoneTypeRepository> GetPhoneTypeAsync(int id, bool trackChanges);
    }
}
