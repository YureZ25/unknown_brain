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

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute] string id)
        {
            if (!Guid.TryParse(id, out Guid guid))
                return BadRequest("Guid is invalid");

            var result = await _welcomeFormService.GetByIdAsync(guid);
            return SendResponse(result);
        }

        [HttpPost]
        public async Task<IActionResult> PostFormAsync([FromBody] WelcomeFormVM welcomeFormVM)
        {
            var result = await _welcomeFormService.ProcessAsync(welcomeFormVM);
            return SendResponse(result);
        }
    }
}
