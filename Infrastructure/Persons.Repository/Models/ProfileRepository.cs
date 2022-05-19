using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Persons.Contracts.interfaces;
using Persons.Entities.DataTransferObject;
using Persons.Entities.Models;
using Persons.Entities.RepositoryContexts;

namespace Persons.Repository.Models
{
    public class ProfileRepository : RepositoryBase<Persons.Entities.Models.Person>, IProfileRepository
    {
        public ProfileRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreateProfile(Entities.Models.Person person)
        {
            CreateProfile(person);
        }

        public void DeletePerson(Entities.Models.Person person)
        {
            DeletePerson(person);
        }

        public async Task<Persons.Entities.Models.Person> GetProfile(int id, bool trackChanges) =>
           await FindByCondition(c => c.BusinessEntityID.Equals(id), trackChanges).SingleOrDefaultAsync();

        public void UpdatePerson(Entities.Models.Person person)
        {
            Update(person);
        }
    }
}
