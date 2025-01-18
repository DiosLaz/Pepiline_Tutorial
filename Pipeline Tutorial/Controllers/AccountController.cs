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

        [HttpGet("/Login")]
        public IActionResult Login()
        {
            return Ok("Works fine");
        }


        [HttpGet("/Register")]
        public IActionResult Register()
        {
            return Ok("Works fine");
        }
    }
}
