using Admin.Api.Dtos;
using Admin.Api.Model;
using Admin.Api.Repositories.Interfaces;
using Admin.Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Admin.Api.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly ITokenService _tokenService;
        public AuthenticationController(ITokenService tokenService)
        {
            _tokenService = tokenService;
        }

        [HttpPost("login", Name = "login")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult Login(LoginDto login)
        {
            var token = _tokenService.GenerateToken(login);

            if (string.IsNullOrEmpty(token)) 
                return Unauthorized();

            return Ok(token);
        }
    }
}
