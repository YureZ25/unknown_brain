using UB.Data.Domain;
using UB.Data.Repositories.Interfaces;
using UB.Data.Domain;


namespace UB.Data.Repositories
{
    internal class SpecializationRepository : BaseRepository<User>, ISpecializationRepository
    {
        public SpecializationRepository(AppDbContext context) : base(context)
        {
        }


    }
}
