using GatewayAPI.Models;
using GatewayAPI.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GatewayAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IManageUSer<UserDTO> _manageUser;

        public UserController(IManageUSer<UserDTO> manageUSer)
        {
            _manageUser = manageUSer;
        }
       [Route("Register")]
       [HttpPost]
       public async Task<IActionResult> Register(UserDTO user)
        {
            var myUser = await _manageUser.Add(user);

            if (myUser == null)
                return BadRequest("Could not register user");
            return Ok(myUser);
        }
        [Route("Login")]
        [HttpPost]
        public async Task<IActionResult> Login(UserDTO user)
        {
            var myUser = await _manageUser.Login(user);

            if (myUser == null)
                return BadRequest("Invalid Username or Password");
            return Ok(myUser);
        }
    }
}
