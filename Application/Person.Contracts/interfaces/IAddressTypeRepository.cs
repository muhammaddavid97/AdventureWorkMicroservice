using Persons.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Contracts.interfaces
{
    public interface IAddressTypeRepository
    {
        Task<IEnumerable<AddressType>> GetAllAddressType(bool trackChanges);
        Task<AddressType> GetAddressType(int id, bool trackChanges);
        void CreateAddressType(AddressType addressType);
        void DeleteAddressType(AddressType addressType);
        void UpdateAddressType(AddressType addressType);
    }
}
