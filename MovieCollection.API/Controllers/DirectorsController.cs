using Microsoft.AspNetCore.Mvc;
using MovieCollection.BLL.Interfaces;
using MovieCollection.Common.DTO.Directors;
using System;

namespace MovieCollection.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectorsController : ControllerBase
    {
        private readonly IDirectorsService _directorsService;

        public DirectorsController(IDirectorsService directorsService)
        {
            _directorsService = directorsService;
        }

        // GET api/Directors
        [HttpGet]
        public async Task<IActionResult> GetDirectors()
        {
            var director = await _directorsService.GetDirectors();
            if (director == null)
            {
                return NotFound();
            }
            return Ok(director);
        }

        // GET api/Directors/Details
        [HttpGet("Details")]
        public async Task<IActionResult> GetDirectorDetails()
        {
            var director = await _directorsService.GetDirectorDetails();
            if (director == null)
            {
                return NotFound();
            }
            return Ok(director);
        }

        // GET api/Directors/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var director = await _directorsService.GetById(id);
            if (director == null)
            {
                return NotFound();
            }
            return Ok(director);
        }

        // POST api/Directors
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateDirectorDTO director)
        {
            try
            {
                await _directorsService.Add(director);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
            return Ok(director);
        }

        //PUT api/Directors
        [HttpPut]
        public async Task<IActionResult> Put(int id, UpdateDirectorDTO director)
        {
            if (director == null)
            {
                return NotFound();
            }
            await _directorsService.Update(id, director);
            return Ok(director);
        }

        //DELETE api/Directors
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var director = await _directorsService.GetById(id);
            if (director == null)
            {
                return NotFound();
            }
            await _directorsService.Delete(id);
            return NoContent();
        }
    }
}
