using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartOpsAPI.Models;
using SmartOpsAPI.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartOpsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private ISmartOpsRepository _smartOpsRepository;
        private IUserRepository _userRepository;
        public UserController(ISmartOpsRepository smartOpsRepository, IUserRepository userRepository)
        {
            _smartOpsRepository = smartOpsRepository; 
            _userRepository = userRepository;
        }

        [AllowAnonymous]
        [HttpPost("Register")]
        public IActionResult RegisterUser([FromBody] User usrmodel, string password)
        {
            var result = _userRepository.Register(usrmodel);

            if (!result)
            {
                return BadRequest( new { message = "User not Created Successfully" });
            
            }

            return Ok(result);
        }
    }
}
