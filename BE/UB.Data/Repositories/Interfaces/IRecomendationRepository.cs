using UB.Data.Domain;

namespace UB.Data.Repositories.Interfaces
{
    public interface IRecomendationRepository : IRepository<Recomendation>
    {
        Task<IList<Recomendation>> GetByGradeAndSpecialization(Guid gradeId, Guid specializationId);

        Task<IList<Recomendation>> GetGeneralRecomendations();
    }
}
