using Persons.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Contracts.Interfaces
{
    public interface IPasswordRepository
    {
        Task<IEnumerable<Password>> GetAllPasswordAsync(bool trackChanges);
        Task<Password> GetPasswordAsync(int id, bool trackChanges);
        void CreatePasswordAsync(Password password);
        void DeletePasswordAsync(Password password);
        void UpdatePasswordAsync(Password password);
    }
}
