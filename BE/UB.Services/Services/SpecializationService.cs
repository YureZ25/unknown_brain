using AutoMapper;
using UB.Data.Domain;
using UB.Data.Repositories.Interfaces;
using UB.Services.Dtos;
using UB.Services.Interfaces;

namespace UB.Services.Services
{
    internal class SpecializationService : ISpecializationService
    {
        private readonly ISpecializationRepository _specializationRepository;
        private readonly IMapper _mapper;

        public SpecializationService(ISpecializationRepository specializationService, IMapper mapper)
        {
            _specializationRepository = specializationService;
            _mapper = mapper;
        }

        public async Task<RespModel<IList<SpecializationsDto>>> GetAllAsync()
        {
            var Specializations = await _specializationRepository.GetAllAsync();
            var SpecializationsDto = _mapper.Map<IList<SpecializationsDto>>(Specializations);
            return new RespModel<IList<SpecializationsDto>>(SpecializationsDto);
        }
    }
}