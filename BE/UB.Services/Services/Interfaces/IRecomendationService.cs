using UB.Services.Dtos;

namespace UB.Services.Services.Interfaces
{
    public interface IRecomendationService
    {
        Task<RespModel<IList<RecomendationDto>>> GenerateRecomendations(Guid welcomeFormId);
    }
}
