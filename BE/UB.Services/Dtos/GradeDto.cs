using AutoMapper;
using UB.Data.Domain;

namespace UB.Services.Dtos
{
    public class GradeDto
    {
        public string Name { get; set; }
    }

    public class GradeMappingProfile : Profile
    {
        public GradeMappingProfile()
        {
            CreateMap<Grade, GradeDto>().ReverseMap();
        }
    }

}
