using Persons.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Contracts.interfaces
{
    public interface IPhoneNumberTypeRepository
    {
        Task<IEnumerable<PhoneNumberType>> GetAllPhoneNumberType(bool trackChanges);
        Task<PhoneNumberType> GetPhoneNumberType(int id, bool trackChanges);
        void CreatePhoneNumberType(PhoneNumberType phoneNumberType);
        void DeletePhoneNumberType(PhoneNumberType phoneNumberType);
        void UpdatePhoneNumberType(PhoneNumberType phoneNumberType);
    }
}
