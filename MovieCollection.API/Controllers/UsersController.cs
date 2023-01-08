using Microsoft.AspNetCore.Mvc;
using MovieCollection.BLL.Interfaces;
using MovieCollection.BLL.Services;
using MovieCollection.Common.DTO.Users;
using System;

namespace MovieCollection.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersService _usersService;

        public UsersController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        // GET api/Users
        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var user = await _usersService.GetUsers();
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        // GET api/Users/Details
        [HttpGet("Details")]
        public async Task<IActionResult> GetUserDetails()
        {
            var user = await _usersService.GetUserDetails();
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        // GET api/Users/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var user = await _usersService.GetById(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        // POST api/Users
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateUserDTO user)
        {
            try
            {
                await _usersService.Add(user);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
            return Ok(user);
        }

        //PUT api/Users
        [HttpPut]
        public async Task<IActionResult> Put(int id, UpdateUserDTO user)
        {
            if (user == null)
            {
                return NotFound();
            }
            await _usersService.Update(id, user);
            return Ok(user);
        }

        //DELETE api/Users
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var user = await _usersService.GetById(id);
            if (user == null)
            {
                return NotFound();
            }
            await _usersService.Delete(id);
            return NoContent();
        }
    }
}
