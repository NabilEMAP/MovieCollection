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

        // GET api/Movies
        [HttpGet]
        public async Task<IActionResult> GetMovies()
        {
            var movie = await _moviesService.GetMovies();
            if (movie == null)
            {
                return NotFound();
            }
            return Ok(movie);
        }

        // GET api/Movies/Details
        [HttpGet("Details")]
        public async Task<IActionResult> GetMovieDetails()
        {
            var movie = await _moviesService.GetMovieDetails();
            if (movie == null)
            {
                return NotFound();
            }
            return Ok(movie);
        }

        // GET api/Movies/{id}
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

        // POST api/Movies
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

        //PUT api/Movies
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

        //DELETE api/Movies
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
