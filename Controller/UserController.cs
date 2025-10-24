using Microsoft.AspNetCore.Mvc;
using ServiceLayer.ServiceInterFace;


namespace Smart_School_Management.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService service)
        {
            _userService = service;
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddUser(string name, int age)
        {
            var data = await _userService.AddUserAsync(name, age);
            return Ok(data);
        }
    }
}