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
        public IActionResult Logins()
        {
            return Ok("Works fines login updated");
        }


        [HttpGet("/Register")]
        public IActionResult Registers()
        {
            return Ok("Works fine, register updated");
        }
    }
}
