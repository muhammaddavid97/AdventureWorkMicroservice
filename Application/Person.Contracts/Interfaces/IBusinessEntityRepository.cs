using Persons.Entities.DataTransferObject;
using Persons.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Contracts.Interfaces
{
    public interface IBusinessEntityRepository
    {
        Task<IEnumerable<BusinessEntity>> GetAllBusinessEntityAsync(bool trackChanges);
        Task<BusinessEntity> GetBusinessEntityAsync(int id, bool trackChanges);
        public void CreateBusinessEntityAsync(BusinessEntity be);
        public void DeleteBusinessEntityAsync(BusinessEntity be);
        public void UpdateBusinessEntityAsync(BusinessEntity be);
    }
}
