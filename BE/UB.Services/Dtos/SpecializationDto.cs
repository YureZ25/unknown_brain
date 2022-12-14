using AutoMapper;
using UB.Data.Domain;

namespace UB.Services.Dtos
{
    public class SpecializationDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }

    public class SpecializationMappingProfile : Profile
    {
        public SpecializationMappingProfile()
        {
            CreateMap<Specialization, SpecializationDto>().ReverseMap();
        }
    }
}
