using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persons.Entities.Models;

namespace Persons.Contracts.interfaces
{
    public interface IPhoneNumberRepository
    {
        //Task<IEnumerable<PersonPhone>> GetAllPersonPhone(bool trackChanges);
        Task<PersonPhone> GetPersonPhone(int id, bool trackChanges);
        void CreatePersonPhone(PersonPhone personPhone);
        void DeletePersonPhone(PersonPhone personPhone);
    }
}
