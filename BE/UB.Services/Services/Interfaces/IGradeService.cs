using UB.Services.Dtos;

namespace UB.Services.Services.Interfaces
{
    public interface IGradeService
    {
        Task<RespModel<IList<GradeDto>>> GetAllAsync();
    }
}
