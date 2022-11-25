namespace UB.Data.UnitOfWork
{
    internal class UoW : IUoW
    {
        private readonly AppDbContext _context;

        public UoW(AppDbContext context)
        {
            _context = context;
        }

        public async Task<int> SaveAsync(CancellationToken cancellationToken = default)
        {
            return await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
