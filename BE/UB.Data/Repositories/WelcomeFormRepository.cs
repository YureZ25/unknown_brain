using UB.Data.Domain;
using UB.Data.Repositories.Interfaces;

namespace UB.Data.Repositories
{
    internal class WelcomeFormRepository : BaseRepository<WelcomeForm>, IWelcomeFormRepository
    {
        public WelcomeFormRepository(AppDbContext context) : base(context)
        {
        }
    }
}
