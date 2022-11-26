using UB.Services.Dtos;
using UB.Services.ViewModels;

namespace UB.Services.Services.Interfaces
{
    public interface IWelcomeFormService
    {
        Task<RespModel<WelcomeFormDto>> ProcessAsync(WelcomeFormVM welcomeFormVM);
    }
}
