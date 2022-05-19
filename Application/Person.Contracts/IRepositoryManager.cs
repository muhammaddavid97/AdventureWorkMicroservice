using Persons.Contracts.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Contracts
{
    public interface IRepositoryManager
    {
        IPersonRepository Person { get; }
        IProfileRepository Profile { get; }
       /* IEmailAddressRepository EmailAddress { get; }
        IPhoneNumberRepository PhoneNumber { get; }*/
        Task saveAsync();
    }
}
