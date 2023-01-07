using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MovieCollection.UI.Controllers.MovieCollectionClient;
using MovieCollection.UI.Models;
using Newtonsoft.Json;
using System.Text;

namespace MovieCollection.UI.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMovieClient _movieClient;
        public MoviesController(IMovieClient movieClient)
        {
            _movieClient = movieClient;
        }

        public IActionResult Index()
        {
            var modelList = _movieClient.GetMovies().Result;
            return View(modelList);
        }

        // GET-Create
        public IActionResult Create()
        {
            var countryList = _movieClient.GetCountries().Result;
            var directorList = _movieClient.GetDirectors().Result;
            ViewData["CountryId"] = new SelectList(countryList, "Id", "Name");
            ViewData["DirectorId"] = new SelectList(directorList, "Id", "Fullname");
            return View();

        }

        // POST-Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(MovieViewModel model)
        {
            var response = _movieClient.CreateMovie(model);
            if (response.Result)
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }

        // GET-Update
        public IActionResult Update(int id)
        {
            var response = _movieClient.GetMovieById(id).Result;
            var countryList = _movieClient.GetCountries().Result;
            var directorList = _movieClient.GetDirectors().Result;
            ViewData["CountryId"] = new SelectList(countryList, "Id", "Name");
            ViewData["DirectorId"] = new SelectList(directorList, "Id", "Fullname");
            return View(response);
        }

        // POST-Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(MovieViewModel model)
        {
            var response = _movieClient.UpdateMovie(model);
            if (response.Result)
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }

        //GET-Delete
        public IActionResult Delete(int id)
        {
            var response = _movieClient.GetMovieById(id).Result;
            var countryList = _movieClient.GetCountries().Result;
            var directorList = _movieClient.GetDirectors().Result;
            ViewData["CountryId"] = new SelectList(countryList, "Id", "Name");
            ViewData["DirectorId"] = new SelectList(directorList, "Id", "Fullname");
            return View(response);
        }

        // POST-Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(MovieViewModel model)
        {
            var response = _movieClient.DeleteMovie(model);
            if (response.Result)
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
