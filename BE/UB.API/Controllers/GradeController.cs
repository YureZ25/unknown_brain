using Microsoft.AspNetCore.Mvc;
using UB.Services.Services.Interfaces;

namespace UB.API.Controllers
{
    [Route("api/grade")]
    public class GradeController : BaseApiController
    {
        private readonly IGradeService _gradeService;

        public GradeController(IGradeService gradeService)
        {
            _gradeService = gradeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var result = await _gradeService.GetAllAsync();
            return SendResponse(result);
        }
    }
}