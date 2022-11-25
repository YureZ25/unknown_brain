using UB.Data.Domain;

namespace UB.Data.Repositories.Interfaces
{
    public interface IRepository<TEntity>
        where TEntity : Entity
    {
        Task<IList<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(Guid id);
        Task<TEntity> InsertAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task<TEntity> DelateAsync(Guid id);
    }
}
