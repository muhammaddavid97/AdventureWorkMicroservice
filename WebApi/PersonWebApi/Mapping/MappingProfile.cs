using AutoMapper;
using Persons.Entities.DataTransferObject;
using Persons.Entities.Models;

namespace PersonWebApi.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<PersonSignUpDto, User>();
        }
    }
}
