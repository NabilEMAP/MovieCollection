using Microsoft.AspNetCore.Mvc;
using MovieCollection.BLL.Interfaces;
using MovieCollection.Common.DTO.Directors;
using System;

namespace MovieCollection.API.Controllers
{
    public class DirectorsController : ControllerBase
    {
        private readonly IDirectorsService _directorsService;

        public DirectorsController(IDirectorsService directorsService)
        {
            _directorsService = directorsService;
        }

        // GET api/Director
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var director = await _directorsService.GetAll();
            if (director == null)
            {
                return NotFound();
            }
            return Ok(director);
        }

        // GET api/Director/1
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

        // POST api/Director
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

        //PUT api/Director/1
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

        //DELETE api/Director/1
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
