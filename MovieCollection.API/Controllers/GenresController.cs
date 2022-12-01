using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieCollection.BLL.Interfaces;
using MovieCollection.DAL.Contexts;
using MovieCollection.DAL.Models;
using System;

namespace MovieCollection.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : ControllerBase
    {
        // GET api/Genre
        [HttpGet]
        public async Task<IActionResult> Get()
        {

            return Ok();
        }

        // GET api/Genre/1
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            
            return Ok();
        }

        // POST api/Genre
        [HttpPost]
        public async Task<IActionResult> Post(Genre genre)
        {

            return Ok();
        }

        // PUT api/Genre/1
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Genre genre)
        {

            return Ok();
        }

        // DELETE api/Genre/1
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {

            return Ok();
        }
    }
}
