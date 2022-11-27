using UB.Data.Domain;
using UB.Data.Repositories.Interfaces;


namespace UB.Data.Repositories
{
    internal class SpecializationRepository : BaseRepository<Specialization>, ISpecializationRepository
    {
        public SpecializationRepository(AppDbContext context) : base(context)
        {
        }


    }
}
