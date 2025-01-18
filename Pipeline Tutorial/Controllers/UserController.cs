using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Pipeline_Tutorial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        [HttpGet("/User")]
        public IActionResult Users(string username)
        {
            return( Ok(username));
        }
    }
}
