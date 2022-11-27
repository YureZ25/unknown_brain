using Microsoft.EntityFrameworkCore;
using UB.Data.Domain;
using UB.Data.Repositories.Interfaces;

namespace UB.Data.Repositories
{
    internal class RecomendationRepository : BaseRepository<Recomendation>, IRecomendationRepository
    {
        public RecomendationRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IList<Recomendation>> GetByGradeAndSpecialization(Guid gradeId, Guid specializationId)
        {
            return await _context.Recomendations
                .Where(e => e.GradeId == gradeId && e.SpecializationId == specializationId)
                .ToListAsync();
        }

        public async Task<IList<Recomendation>> GetGeneralRecomendations()
        {
            return await _context.Recomendations
                .Where(e => !e.GradeId.HasValue && !e.SpecializationId.HasValue)
                .ToListAsync();
        }
    }
}
