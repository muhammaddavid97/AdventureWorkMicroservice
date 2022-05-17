using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persons.Contracts.Interfaces;

namespace Persons.Contracts
{
    public interface IRepositoryManager
    {
        IPersonRepository Person { get; }
        IBusinessEntityRepository Business { get; }
        IAddressRepository Address { get; }
        IEmailRepository Email { get; }
        IPhoneNumberRepository PhoneNumber { get; }
        IPasswordRepository Password { get; }

        void Save();

        Task SaveAsync();
    }
}
