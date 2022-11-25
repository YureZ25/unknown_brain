using Microsoft.AspNetCore.Mvc;
using UB.API.Models;
using UB.Services;

namespace UB.API.Controllers
{
    [ApiController]
    public class BaseApiController : ControllerBase
    {
        protected IActionResult SendResponse<T>(RespModel<T> resp) where T : class
        {
            if (resp is null)
                return BadRequest("Response is empty");

            if (resp.Success)
                return Ok(resp.Data);
            else
                return BadRequest(new ErrorModel(resp.ErrorMessage));
        }
    }
}
