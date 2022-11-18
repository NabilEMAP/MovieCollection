using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieCollection.BLL.Interfaces;
using System;

namespace MovieCollection.API.Controllers
{
    public class MoviesController : APIv1Controller
    {
        private readonly IMoviesService moviesService;

        public MoviesController(IMoviesService moviesService)
        {
            this.moviesService = moviesService;
        }

        [HttpGet]   //api/movies?lastname=El Moussaoui
        public IActionResult GetAllMovies([FromQuery] string lastName, [FromQuery] int pageNr = 1, [FromQuery] int pageSize = 10)
        {
            return Ok(moviesService.GetAll(pageNr, pageSize));
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetMovie(int id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public IActionResult CreateMovie()
        {
            throw new NotImplementedException();
        }

        [Route("{id}")]  //api/movies/id
        [HttpDelete]
        public IActionResult DeleteMovie(int id, [FromHeader(Name = "X-AccessKey")] string AccessKey)
        {
            try
            {
                moviesService.Delete(id);
                return NoContent();
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound();
            }
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult UpdateMovie(int id)
        {
            throw new NotImplementedException();
        }
    }
}
