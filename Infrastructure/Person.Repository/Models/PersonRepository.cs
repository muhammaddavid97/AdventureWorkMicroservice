using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Persons.Contracts.Interfaces;
using Persons.Entities.Contexts;
using Persons.Entities.Models;

namespace Persons.Repository.Models
{
    internal class PersonRepository : RepositoryBase<Person>, IPersonRepository
    {
        public PersonRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreatePersonAsync(Person person)
        {
            Create(person);
        }

        public void DeletePersonAsync(Person person)
        {
            Delete(person);
        }

        public async Task<IEnumerable<Person>> GetAllPersonAsync(bool trackChanges)
        {
            return await FindAll(trackChanges)
                    .OrderBy(c => c.BusinessEntityID)
                    .ToListAsync();
        }

        public async Task<Person> GetPersonAsync(int id, bool trackChanges) =>
            await FindByCondition(c => c.BusinessEntityID.Equals(id), trackChanges).SingleOrDefaultAsync();

        public void UpdatePersonAsync(Person person)
        {
            Update(person);
        }
    }
}
