using AutoMapper;
using UB.Data.Domain;

namespace UB.Services.Dtos
{
    public class GradeDto
    {
        public Guid Id {get; set;}
        public string Name { get; set; }
        public string Recomendation { get; set; }
        public string RecomendationUrl { get; set; }
    }

    public class GradeMappingProfile : Profile
    {
        public GradeMappingProfile()
        {
            CreateMap<Grade, GradeDto>().ReverseMap();
        }
    }

}
