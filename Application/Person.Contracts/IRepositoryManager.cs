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
        IPersonTypeRepository PersonTypesView { get; }
        IRegionPersonRepository RegionPersonView { get; }
        IBeAddressRepository BeAddress { get; }
        IStateProvinceRepository StateProvince { get; }

        void Save();

        Task SaveAsync();
    }
}
