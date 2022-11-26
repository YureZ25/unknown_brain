using AutoMapper;
using UB.Data.Domain;

namespace UB.Services.Dtos
{
    public class WelcomeFormDto
    {
        public Guid Id { get; set; }
        public bool IsPM { get; set; }
        public bool IsDocWriter { get; set; }
        public UserDto User { get; set; }
        public SpecializationDto Specialization { get; set; }
        public GradeDto Grade { get; set; }
    }

    public class WelcomeFormMappingProfile : Profile
    {
        public WelcomeFormMappingProfile()
        {
            CreateMap<WelcomeForm, WelcomeFormDto>().ReverseMap();
        }
    }
}
