using Microsoft.EntityFrameworkCore;
using Persons.Contracts.interfaces;
using Persons.Entities.RepositoryContexts;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Persons.Repository.Models
{
    public class PersonRepository : RepositoryBase<Persons.Entities.Models.Person>, IPersonRepository
    {
        public PersonRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }

        public void CreatePerson(Entities.Models.Person person)
        {
            Create(person);
        }

        public void DeletePerson(Entities.Models.Person person)
        {
            Delete(person);
        }

        public async Task<IEnumerable<Persons.Entities.Models.Person>> GetAllPerson(bool trackChanges) =>
            await FindAll(trackChanges)
            .OrderBy(p => p.BusinessEntityID)
            .ToListAsync();

        public async Task<Persons.Entities.Models.Person> GetPerson(int id, bool trackChanges) =>
            await FindByCondition(c => c.BusinessEntityID.Equals(id), trackChanges).SingleOrDefaultAsync();

        public void UpdatePerson(Entities.Models.Person person)
        {
        }
    }
}
