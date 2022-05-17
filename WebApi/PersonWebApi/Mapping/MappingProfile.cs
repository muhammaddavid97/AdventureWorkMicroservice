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
        }
    }
}
