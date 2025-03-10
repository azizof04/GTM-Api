using Microsoft.AspNetCore.Mvc;
using GTM.Business.Services;
using System.Threading.Tasks;
using GTM.Business.DTOs;

namespace GTM.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly AuthService _authService;

        public UserController(AuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDto registerDto)
        {
            var result = await _authService.RegisterAsync(registerDto.Username, registerDto.Email, registerDto.Password, registerDto.Firstname, registerDto.LastName);

            if (result.Contains("Bu email zaten kayıtlı!") || result.Contains("hata"))
                return BadRequest(new { message = result });

            return Ok(new { message = result });
        }
    }
}
