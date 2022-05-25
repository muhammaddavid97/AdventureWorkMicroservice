using Persons.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Contracts.interfaces
{
    public interface IAddressRepository
    {
        Task<IEnumerable<Address>> GetAllAddress(bool trackChanges);
        Task<Address> GetAddress(int id, bool trackChanges);
        void CreateAddress(Address address);
        void DeleteAddress(Address address);
        void UpdateAddress(Address address);
    }
}
