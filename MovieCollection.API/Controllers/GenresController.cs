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
        private readonly IGenresService genreService;

        public GenresController(IGenresService genreService)
        {
            this.genreService = genreService;
        }

        [HttpGet]
        public IActionResult GetAll([FromQuery] string lastName, [FromQuery] int pageNr = 1, [FromQuery] int pageSize = 10)
        {
            return Ok(genreService.GetAll(pageNr, pageSize));
        }
        

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
            
            return Ok(await genreService.GetById(id));
        }

        // POST api/Genre
        [HttpPost]
        public async Task<IActionResult> Post(Genre genre)
        {

            return Ok(await genreService.Add(genre));
        }

        // PUT api/Genre/1
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Genre genre)
        {

            return Ok(await genreService.Update(genre));
        }

        // DELETE api/Genre/1
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await genreService.Delete(id);
                return NoContent();
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound();
            }
            return Ok();
        }
    }
}
