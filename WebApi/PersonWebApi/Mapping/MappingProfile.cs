using AutoMapper;
using Persons.Entities.DataTransferObject;
using Persons.Entities.Models;

namespace PersonWebApi.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Persons.Entities.Models.Person, PersonDto>().ReverseMap();

            CreateMap<PersonSignUpDto, User>();
            
            CreateMap<BusinessEntityDto, BusinessEntity>();

            CreateMap<EmailDto, EmailAddress>();

            CreateMap<EmailAddress, EmailDto>();

            CreateMap<PersonPhone, PhoneNumberDto>();

            CreateMap<BusinessEntityAddress, BusinessEntityAddressDto>();

            CreateMap<Address, AddressDto>();

            CreateMap<StateProvince, StateProvinceDto>();

            CreateMap<VPersonType, VPersonTypeDto>();

            CreateMap<VRegionPerson, VRegionPersonDto>();
        }
    }
}
