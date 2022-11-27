using Microsoft.AspNetCore.Mvc;
using UB.Services.Services.Interfaces;
using UB.Services.ViewModels;

namespace UB.API.Controllers
{
    [Route("api/welcome-form")]
    public class WelcomeFormController : BaseApiController
    {
        private readonly IWelcomeFormService _welcomeFormService;

        public WelcomeFormController(IWelcomeFormService welcomeFormService)
        {
            _welcomeFormService = welcomeFormService;
        }

        [HttpPost]
        public async Task<IActionResult> PostFormAsync([FromBody] WelcomeFormVM welcomeFormVM)
        {
            var result = await _welcomeFormService.ProcessAsync(welcomeFormVM);
            return SendResponse(result);
        }
    }
}
