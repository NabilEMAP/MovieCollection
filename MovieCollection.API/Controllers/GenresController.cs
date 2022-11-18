using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieCollection.BLL.Interfaces;
using System;

namespace MovieCollection.API.Controllers
{
    public class GenresController : APIv1Controller
    {
        private readonly IGenresService genresService;

        public GenresController(IGenresService genresService)
        {
            this.genresService = genresService;
        }

        [HttpGet]   //api/genres?lastname=El Moussaoui
        public IActionResult GetAllGenres([FromQuery] string lastName, [FromQuery] int pageNr = 1, [FromQuery] int pageSize = 10)
        {
            return Ok(genresService.GetAll(pageNr, pageSize));
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetGenre(int id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public IActionResult CreateGenre()
        {
            throw new NotImplementedException();
        }

        [Route("{id}")]  //api/genres/id
        [HttpDelete]
        public IActionResult DeleteGenre(int id, [FromHeader(Name = "X-AccessKey")] string AccessKey)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult UpdateGenre(int id)
        {
            throw new NotImplementedException();
        }
    }
}
