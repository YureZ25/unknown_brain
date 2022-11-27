using Microsoft.EntityFrameworkCore;
using UB.Data.Domain;
using UB.Data.Repositories.Interfaces;

namespace UB.Data.Repositories
{
    internal class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<bool> CheckExistByUserNameAsync(string userName)
        {
            var existUser = await _context.Users.SingleOrDefaultAsync(e => e.UserName.ToLowerInvariant() == userName.ToLowerInvariant());

            if (existUser is null)
                return false;

            return true;
        }

        public async Task<User> GetByUserNameAsync(string userName)
        {
            return await _context.Users.SingleOrDefaultAsync(e => e.UserName == userName);
        }
    }
}
