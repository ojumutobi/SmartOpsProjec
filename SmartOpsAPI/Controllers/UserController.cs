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
        [ProducesResponseType(201, Type = typeof(User))]
        public IActionResult RegisterUser([FromBody] User usrmodel, string password)
        {
            var result = _userRepository.Register(usrmodel);

            if (!result)
            {
                return BadRequest( new { message = "User not Created Successfully" });            
            }

            return Ok(result);
        }



        [AllowAnonymous]
        [HttpGet]
        public IActionResult GetUsers()
        {
            var result = _smartOpsRepository.GetUsers();

            if (result.Count <= 0)
            {
                return BadRequest(new { message = "No record found" });

            }

            return Ok(result);
        }

        [AllowAnonymous]        
        [HttpGet("{usrID}", Name = "GetUserById")]
        public IActionResult GetUserById(int usrID)
        {
            var result = _smartOpsRepository.GetUser(usrID);

            if (result == null)
            {
                return BadRequest(new { message = "No record found" });
            }

            return Ok(result);
        }


        [AllowAnonymous]
        [HttpPut("{usrID}", Name = "UpdateUserById")]
        [HttpPut("UpdateUserById")]

        [ProducesResponseType(201, Type = typeof(User))]
        public IActionResult UpdateUserById(User usr)
        {
            var result = _smartOpsRepository.UpdateUser(usr);

            if (result == false)
            {
                return BadRequest(new { message = "No record found" });
            }

            if (result)
            {
                return Ok(result);
            }

            return Ok(result);
        }

        [AllowAnonymous]
        [HttpGet("CountAllUsers")]
        public IActionResult CountAllUsers()
        {
            var result = _smartOpsRepository.CountAllUsers();
            if (result == null)
            {
                return BadRequest(new { message = "No Record found" });
            }
            return Ok(result);

        }
    }
}
