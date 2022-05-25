using Persons.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Contracts.interfaces
{
    public interface IStateProvinceRepository
    {
        Task<IEnumerable<StateProvince>> GetAllStateProvince(bool trackChanges);
        Task<StateProvince> GetStateProvince(int id, bool trackChanges);
        void CreateStateProvince(StateProvince stateProvince);
        void DeleteStateProvince(StateProvince stateProvince);
        void UpdateStateProvince(StateProvince stateProvince);
    }
}
