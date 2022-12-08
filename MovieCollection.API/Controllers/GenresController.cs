using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieCollection.BLL.Interfaces;
using MovieCollection.BLL.Services;
using MovieCollection.Common.DTO;
using MovieCollection.Common.DTO.Genres;
using MovieCollection.DAL.Models;

namespace MovieCollection.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : ControllerBase
    {
        private readonly IGenresService _genresService;

        public GenresController(IGenresService genresService)
        {
            _genresService = genresService;
        }

        // GET api/Genre
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var genre = await _genresService.GetAll();
            if (genre == null)
            {
                return NotFound();
            }
            return Ok(genre);
        }

        // GET api/Genre/1
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var genre = await _genresService.GetById(id);
            if (genre == null)
            {
                return NotFound();
            }
            return Ok(genre);
        }

        // POST api/Genre
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateGenreDTO genre)
        {
            try
            {
                await _genresService.Add(genre);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
            return Ok(genre);
        }

        //PUT api/Genre/1
        [HttpPut]
        public async Task<IActionResult> Put(int id, UpdateGenreDTO genre)
        {
            if (genre == null)
            {
                return NotFound();
            }
            await _genresService.Update(id, genre);
            return Ok(genre);
        }

        //DELETE api/Genre/1
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var genre = await _genresService.GetById(id);
            if (genre == null)
            {
                return NotFound();
            }
            await _genresService.Delete(id);
            return NoContent();
        }

    }
}
