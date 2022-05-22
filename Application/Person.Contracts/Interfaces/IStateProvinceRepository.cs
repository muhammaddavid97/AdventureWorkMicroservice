using Persons.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Contracts.Interfaces
{
    public interface IStateProvinceRepository
    {
        Task<IEnumerable<StateProvince>> GetAllStateProvinceAsync(bool trackChanges);
        Task<StateProvince> GetStateProvinceAsync(int stateId, bool trackChanges);
        void CreateStateProvincevAsync(StateProvince stateProvince);
        void DeleteStateProvinceAsync(StateProvince stateProvince);
        void UpdateStateProvinceAsync(StateProvince stateProvince);
    }
}
