using Microsoft.AspNetCore.Mvc;
using UB.Services.Interfaces;

namespace UB.API.Controllers
{
    [Route("api/specification")]
    public class SpecializationController : BaseApiController
    {
        private readonly ISpecializationService _specializationService;

        public SpecializationController(ISpecializationService specializationService)
        {
            _specializationService = specializationService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var result = await _specializationService.GetAllAsync();
            return SendResponse(result);
        }
    }
}
