using Microsoft.EntityFrameworkCore;
using Persons.Contracts.interfaces;
using Persons.Entities.Models;
using Persons.Entities.RepositoryContexts;
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

        public void CreateStateProvince(StateProvince stateProvince)
        {
            Create(stateProvince);   
        }

        public void DeleteStateProvince(StateProvince stateProvince)
        {
            Delete(stateProvince);     
        }

        public async Task<IEnumerable<StateProvince>> GetAllStateProvince(bool trackChanges) =>
            await FindAll(trackChanges)
                 .OrderBy(c => c.StateProvinceID)
                 .ToListAsync();

        public async Task<StateProvince> GetStateProvince(int id, bool trackChanges) =>
            await FindByCondition(c => c.StateProvinceID.Equals(id), trackChanges).SingleOrDefaultAsync();

        public void UpdateStateProvince(StateProvince stateProvince)
        {
            Update(stateProvince);
        }
    }
}
