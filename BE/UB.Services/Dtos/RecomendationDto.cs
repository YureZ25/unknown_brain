using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UB.Data.Domain;

namespace UB.Services.Dtos
{
    public class RecomendationDto
    {
        public Guid Id { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
    }

    public class RecomendationMappingProfile : Profile
    {
        public RecomendationMappingProfile()
        {
            CreateMap<Recomendation, RecomendationDto>().ReverseMap();
        }
    }
}
