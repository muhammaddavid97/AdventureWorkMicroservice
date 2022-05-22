using Persons.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Contracts.Interfaces
{
    public interface IAddressRepository
    {
        Task<IEnumerable<Address>> GetAllAddressAsync(bool trackChanges);
        Task<Address> GetAddressAsync(int id, bool trackChanges);
        void CreateAddressAsync(Address address);
        void DeleteAddressAsync(Address address);
        void UpdateAddressrAsync(Address address);
    }
}
