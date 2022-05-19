using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Persons.Contracts.interfaces;
using Persons.Entities.Models;
using Persons.Entities.RepositoryContexts;

namespace Persons.Repository.Models
{
    public class PhoneNumberRepository : RepositoryBase<PersonPhone>, IPhoneNumberRepository
    {
        public PhoneNumberRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreatePersonPhone(PersonPhone personPhone)
        {
           Create(personPhone);
        }

        public void DeletePersonPhone(PersonPhone personPhone)
        {
            Delete(personPhone);
        }
/*
        public async Task<IEnumerable<PersonPhone>> GetAllPersonPhone(bool trackChanges)
        {
           
        }*/

        public async Task<PersonPhone> GetPersonPhone(int id, bool trackChanges) =>
            await FindByCondition(c => c.BusinessEntityID.Equals(id), trackChanges).SingleOrDefaultAsync();

        public void UpdatePersonPhone(PersonPhone personPhone)
        {
            Update(personPhone);
        }
    }
}
