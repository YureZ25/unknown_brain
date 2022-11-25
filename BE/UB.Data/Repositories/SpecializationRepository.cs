using UB.Data.Domain;
using UB.Data.Repositories.Interfaces;

namespace UB.Data.Repositories
{
    internal class SpecializationRepository : BaseRepository<User>, ISpecializationRepository
    {
        public SpecializationRepository(AppDbContext context) : base(context)
        {
        }


    }
}
