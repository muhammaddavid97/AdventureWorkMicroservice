using Persons.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Contracts.interfaces
{
    public interface IBusinessEntityAddressRepository
    {
        Task<IEnumerable<BusinessEntityAddress>> GetAllBusinessEntityAddress(bool trackChanges);
        Task<BusinessEntityAddress> GetBusinessEntityAddress(int id, bool trackChanges);
        void CreateBusinessEntityAddress(BusinessEntityAddress businessEntityAddress);
        void DeleteBusinessEntityAddress(BusinessEntityAddress businessEntityAddress);
        void UpdateBusinessEntityAddress(BusinessEntityAddress businessEntityAddress);
    }
}
