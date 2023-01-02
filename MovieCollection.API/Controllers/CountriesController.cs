using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieCollection.BLL.Interfaces;
using MovieCollection.Common.DTO.Countries;
using MovieCollection.DAL.Contexts;
using MovieCollection.DAL.Models;
using System;

namespace MovieCollection.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private readonly ICountriesService _countriesServices;

        public CountriesController(ICountriesService countriesService)
        {
            _countriesServices = countriesService;
        }

        // GET api/Country
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var countries = await _countriesServices.GetAll();
            if(countries == null) { return NotFound(); }
            return Ok(countries);
        }

        // GET api/Country/1
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var countries = await _countriesServices.GetById(id);
            if (countries == null) { return NotFound(); }
            return Ok(countries);
        }

        // POST api/Genre
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateCountryDTO country)
        {
            try
            {
                await _countriesServices.Add(country);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
            return Ok(country);
        }

        // PUT api/Country/1
        [HttpPut]
        public async Task<IActionResult> Put(int id, UpdateCountryDTO country)
        {
            if(country == null)
            {
                return NotFound();
            }
            await _countriesServices.Update(id, country);
            return Ok(country);
        }

        // DELETE api/Country/1
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var country = await _countriesServices.GetById(id);
            if (country == null)
            {
                return NotFound();
            }
            await _countriesServices.Delete(id);
            return NoContent();
        }
    }
}
