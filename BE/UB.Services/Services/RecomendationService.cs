using AutoMapper;
using UB.Data.Repositories.Interfaces;
using UB.Services.Dtos;
using UB.Services.Services.Interfaces;

namespace UB.Services.Services
{
    internal class RecomendationService : IRecomendationService
    {
        private readonly IWelcomeFormRepository _welcomeFormRepository;
        private readonly IRecomendationRepository _recomendationRepository;
        private readonly IMapper _mapper;

        public async Task<RespModel<IList<RecomendationDto>>> GenerateRecomendations(Guid welcomeFormId)
        {
            var welcomeForm = await _welcomeFormRepository.GetByIdAsync(welcomeFormId);

            var recomendations = await _recomendationRepository.GetByGradeAndSpecialization(
                welcomeForm.GradeId,
                welcomeForm.SpecializationId);

            var recomendationDtos = _mapper.Map<IList<RecomendationDto>>(recomendations);

            return new RespModel<IList<RecomendationDto>>(recomendationDtos);
        }
    }
}
