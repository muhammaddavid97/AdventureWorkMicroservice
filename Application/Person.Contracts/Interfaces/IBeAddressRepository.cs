using Persons.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Contracts.Interfaces
{
    public interface IBeAddressRepository
    {
        Task<IEnumerable<BusinessEntityAddress>> GetAllBeAddressAsync(bool trackChanges);
        Task<BusinessEntityAddress> GetBeAddressAsync(int beId, bool trackChanges);
        void CreateBeAddressAsync(BusinessEntityAddress beAddress);
        void DeleteBeAddressAsync(BusinessEntityAddress beAddress);
        void UpdateBeAddressAsync(BusinessEntityAddress beAddress);
    }
}
