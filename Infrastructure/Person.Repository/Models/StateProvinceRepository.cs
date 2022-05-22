using Microsoft.EntityFrameworkCore;
using Persons.Contracts.Interfaces;
using Persons.Entities.Contexts;
using Persons.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Repository.Models
{
    public class StateProvinceRepository : RepositoryBase<StateProvince>, IStateProvinceRepository
    {
        public StateProvinceRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreateStateProvincevAsync(StateProvince stateProvince)
        {
            Create(stateProvince);
        }

        public void DeleteStateProvinceAsync(StateProvince stateProvince)
        {
            Delete(stateProvince);
        }

        public async Task<IEnumerable<StateProvince>> GetAllStateProvinceAsync(bool trackChanges)
        {
            return await FindAll(trackChanges)
                    .OrderBy(c => c.StateProvinceID)
                    .ToListAsync();
        }

        public async Task<StateProvince> GetStateProvinceAsync(int stateId, bool trackChanges) =>
            await FindByCondition(c => c.StateProvinceID.Equals(stateId), trackChanges).SingleOrDefaultAsync();

        public void UpdateStateProvinceAsync(StateProvince stateProvince)
        {
            Update(stateProvince);
        }
    }
}
