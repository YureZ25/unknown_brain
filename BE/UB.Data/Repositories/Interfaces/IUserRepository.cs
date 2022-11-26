using UB.Data.Domain;

namespace UB.Data.Repositories.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        Task<bool> CheckExistByUserNameAsync(string userName);

        Task<User> GetByUserNameAsync(string userName);
    }
}
