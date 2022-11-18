using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieCollection.BLL.Interfaces;
using System;

namespace MovieCollection.API.Controllers
{
    public class DirectorsController : APIv1Controller
    {
        private readonly IDirectorsService directorsService;

        public DirectorsController(IDirectorsService directorsService)
        {
            this.directorsService = directorsService;
        }

        [HttpGet]   //api/directors?lastname=El Moussaoui
        public IActionResult GetAllDirectors([FromQuery] string lastName, [FromQuery] int pageNr = 1, [FromQuery] int pageSize = 10)
        {
            return Ok(directorsService.GetAll(pageNr, pageSize));
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetDirector(int id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public IActionResult CreateDirector()
        {
            throw new NotImplementedException();
        }

        [Route("{id}")]  //api/directors/id
        [HttpDelete]
        public IActionResult DeleteDirector(int id, [FromHeader(Name = "X-AccessKey")] string AccessKey)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult UpdateDirector(int id)
        {
            throw new NotImplementedException();
        }
    }
}
