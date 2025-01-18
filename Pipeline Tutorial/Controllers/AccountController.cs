using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Pipeline_Tutorial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {

        public AccountController()
        {
            
        }

        [HttpGet]
        public async Task<IActionResult> Login()
        {
            return Ok("Works fine");
        }


        [HttpGet]
        public async Task<IActionResult> Register()
        {
            return Ok("Works fine");
        }
    }
}
