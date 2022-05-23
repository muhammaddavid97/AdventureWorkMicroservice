using Persons.Entities.DataTransferObject;
using Persons.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Contracts
{
    public interface IProfileService
    {
        Task<bool> SaveAll(int businessEntityId, PersonMyProfileDto profileDto);
        

        /*Task<IEnumerable<EmailAddress>> GetEmailByEmailAsync(int businessEntityId);
        Task<IEnumerable<PersonPhone>> GetPhoneNumberByBEIdAsync(int businessEntityId);
        Task<IEnumerable<BusinessEntityAddress>> GetAddressTypeByBEIdAsync(int businessEntityId);
        Task<IEnumerable<Address>> GetAddressByBEIdAsync(int addressId);
        Task<IEnumerable<StateProvince>> GetStateProvinceByBEIdAsync(int stateProvinceId);*/

    }
}
