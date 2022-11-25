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
    }
}
