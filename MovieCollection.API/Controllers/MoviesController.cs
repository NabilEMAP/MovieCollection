using Microsoft.AspNetCore.Mvc;
using MovieCollection.BLL.Interfaces;
using MovieCollection.Common.DTO.Movies;
using System;

namespace MovieCollection.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMoviesService _moviesService;

        public MoviesController(IMoviesService moviesService)
        {
            _moviesService = moviesService;
        }

        // GET api/Movie
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var movie = await _moviesService.GetAll();
            if (movie == null)
            {
                return NotFound();
            }
            return Ok(movie);
        }

        // GET api/Movie/1
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var movie = await _moviesService.GetById(id);
            if (movie == null)
            {
                return NotFound();
            }
            return Ok(movie);
        }

        // POST api/Movie
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateMovieDTO movie)
        {
            try
            {
                await _moviesService.Add(movie);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
            return Ok(movie);
        }

        //PUT api/Movie/1
        [HttpPut]
        public async Task<IActionResult> Put(int id, UpdateMovieDTO movie)
        {
            if (movie == null)
            {
                return NotFound();
            }
            await _moviesService.Update(id, movie);
            return Ok(movie);
        }

        //DELETE api/Movie/1
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var movie = await _moviesService.GetById(id);
            if (movie == null)
            {
                return NotFound();
            }
            await _moviesService.Delete(id);
            return NoContent();
        }
    }
}
