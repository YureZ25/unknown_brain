using Microsoft.EntityFrameworkCore;
using UB.Data.Domain;
using UB.Data.Repositories.Interfaces;

namespace UB.Data.Repositories
{
    internal class WelcomeFormRepository : BaseRepository<WelcomeForm>, IWelcomeFormRepository
    {
        public WelcomeFormRepository(AppDbContext context) : base(context)
        {
        }

        public override async Task<WelcomeForm> GetByIdAsync(Guid id)
        {
            return await _context.WelcomeForms
                .Include(e => e.Grade)
                .Include(e => e.Specialization)
                .Include(e => e.User)
                .SingleOrDefaultAsync(e => e.Id == id);
        }
    }
}
