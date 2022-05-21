using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Contracts.interfaces
{
    public interface IProfileRepository
    {
        Task<Persons.Entities.Models.Person> GetProfile(int id, bool trackChanges);
        void CreateProfile(Persons.Entities.Models.Person person);
        void UpdateProfile(Persons.Entities.Models.Person person);
    }
}
