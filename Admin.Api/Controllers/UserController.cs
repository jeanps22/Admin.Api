using Admin.Api.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Admin.Api.Controllers
{
    [ApiController]
    [Route("v1")]
    [Authorize(Roles = "Manager")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("get-user")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult GetByUserName(string userName)
        {
            var user = _userService.GetByUserName(userName);
            return Ok(user);
        }
    }
}
