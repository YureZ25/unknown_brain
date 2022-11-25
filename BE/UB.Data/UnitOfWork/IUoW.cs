namespace UB.Data.UnitOfWork
{
    public interface IUoW
    {
        Task<int> SaveAsync(CancellationToken cancellationToken = default);
    }
}
