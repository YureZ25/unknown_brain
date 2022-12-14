using UB.Services.Dtos;

namespace UB.Services.Interfaces
{
    public interface IUserService
    {
        Task<RespModel<IList<UserDto>>> GetAllAsync();

        Task<RespModel<UserDto>> GetByIdAsync(Guid id);
    }
}
