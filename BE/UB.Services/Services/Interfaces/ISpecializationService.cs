using UB.Services.Dtos;

namespace UB.Services.Interfaces
{
    public interface ISpecializationService
    {
        Task<RespModel<IList<SpecializationsDto>>> GetAllAsync();
    }
}
