using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Contracts.interfaces
{
    public interface IPersonRepository
    {
        Task<IEnumerable<Persons.Entities.Models.Person>> GetAllPerson(bool trackChanges);
        Task<Persons.Entities.Models.Person> GetPerson(int id, bool trackChanges);
        void CreatePerson(Persons.Entities.Models.Person person);
        void DeletePerson(Persons.Entities.Models.Person person);
        void UpdatePerson(Persons.Entities.Models.Person person);
    }
}
