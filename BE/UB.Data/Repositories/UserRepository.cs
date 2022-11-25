using UB.Data.Domain;
using UB.Data.Repositories.Interfaces;

namespace UB.Data.Repositories
{
    internal class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context)
        {
        }
    }
}
