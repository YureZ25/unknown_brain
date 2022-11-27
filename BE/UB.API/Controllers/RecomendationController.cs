using Microsoft.AspNetCore.Mvc;
using UB.Services.Services.Interfaces;

namespace UB.API.Controllers
{
    [Route("api/grade")]
    public class RecomendationController : BaseApiController
    {
        private readonly IRecomendationService _recomendationService;

        public RecomendationController(IRecomendationService recomendationService)
        {
            _recomendationService = recomendationService;
        }

        [HttpGet("genarate")]
        public async Task<IActionResult> GenarateAsync([FromQuery] Guid welcomeFormId)
        {
            var result = await _recomendationService.GenerateRecomendations(welcomeFormId);
            return SendResponse(result);
        }
    }
}
