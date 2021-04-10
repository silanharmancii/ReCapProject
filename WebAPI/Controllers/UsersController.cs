using Business.Abstract;
using Core.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("update")]

        public IActionResult Update(User user)
        {
            var result = _userService.Update(user);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
           
        }
        [HttpGet("getuserbyid")]

        public IActionResult GetUserById(int userId)
        {
            var result = _userService.GetUserById(userId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();

        }

        [HttpGet("getuserbyemail")]

        public IActionResult GetUserByEmail(string email)
        {
            var result = _userService.GetByMail(email);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();

        }

        [HttpPost("addfindexpoint")]
        public IActionResult AddFindexPoint([FromBody] int userId)
        {
            var result = _userService.AddFindexPoint(userId);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }



    }
   
}
