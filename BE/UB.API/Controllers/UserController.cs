using Microsoft.AspNetCore.Mvc;
using UB.Services.Interfaces;

namespace UB.API.Controllers
{
    [Route("api/user")]
    public class UserController : BaseApiController
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var result = await _userService.GetAllAsync();
            return SendResponse(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute] string id)
        {
            if (!Guid.TryParse(id, out Guid guid))
                return BadRequest("Guid is invalid");

            var result = await _userService.GetByIdAsync(guid);
            return SendResponse(result);
        }
    }
}
