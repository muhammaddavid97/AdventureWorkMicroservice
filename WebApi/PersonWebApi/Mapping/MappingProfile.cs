using AutoMapper;
using Persons.Entities.DataTransferObject;
using Persons.Entities.Models;

namespace PersonWebApi.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<PersonModelDTO, User>().ReverseMap();
            CreateMap<ProfileDTO, Persons.Entities.Models.Person>().ReverseMap();
            CreateMap<Persons.Entities.Models.Person, ProfileDTO>();
            CreateMap<EmailAddressDTO, EmailAddress>().ReverseMap();
            CreateMap<EmailAddress, EmailAddressDTO>();
        }
    }
}
