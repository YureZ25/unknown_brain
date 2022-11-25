using AutoMapper;
using UB.Data.Domain;

namespace UB.Services.Dtos
{
    public class UserDto
    {
        public string UserName { get; set; }
    }

    public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            CreateMap<User, UserDto>().ReverseMap();
        }
    }

}
