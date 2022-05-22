using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persons.Entities.Models;
namespace Persons.Contracts.Interfaces
{
    public interface IPersonRepository
    {
        Task<IEnumerable<Person>> GetAllPersonAsync(bool trackChanges);
        Task<Person> GetPersonAsync(int id, bool trackChanges);
        void CreatePersonAsync(Person person);
        void DeletePersonAsync(Person person);
        void UpdatePersonAsync(Person person);
    }
}
