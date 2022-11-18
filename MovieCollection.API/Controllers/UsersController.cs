using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieCollection.BLL.Interfaces;
using MovieCollection.DAL.Models;
using System;

namespace MovieCollection.API.Controllers
{
    public class UsersController : APIv1Controller
    {
        private readonly IUsersService usersService;

        public UsersController(IUsersService usersService)
        {
            this.usersService = usersService;
        }

        [HttpGet]   //api/users?lastname=El Moussaoui
        public IActionResult GetAllUsers([FromQuery] string lastName, [FromQuery] int pageNr = 1, [FromQuery] int pageSize = 10)
        { 
            return Ok(usersService.GetAll(pageNr, pageSize));
        }

        [HttpGet]   //api/users?lastname=El Moussaoui
        public IActionResult GetAll()
        {
            var result = usersService.GetAll();
            if (result.Any() == false)
                return NotFound();
            return Ok(result);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetUser(int id)
        {
            var result = usersService.GetById(id);
            if(result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpPost]
        public IActionResult CreateUser()
        {
            throw new NotImplementedException();
        }

        [Route("{id}")]  //api/users/id
        [HttpDelete]
        public IActionResult DeleteUser(int id, [FromHeader(Name = "X-AccessKey")] string AccessKey)
        {
            try
            {
                usersService.Delete(id);
                return NoContent();
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound();
            }
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult UpdateUser([FromBody]User user)
        {
            usersService.Update(user);
            return Ok();
        }
    }
}
