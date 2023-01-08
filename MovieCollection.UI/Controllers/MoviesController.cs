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

        public IActionResult Index(int pg)
        {
            var modelList = _movieClient.GetMovies().Result;
            const int pageSize = 10;
            if (pg < 1) { pg = 1; }
            int recsCount = modelList.Count();
            var pager = new Pager(recsCount, pg, pageSize);
            int recSkip = (pg - 1) * pageSize;
            var dataPager = modelList.Skip(recSkip).Take(pager.PageSize).ToList();
            this.ViewBag.Pager = pager;
            return View(dataPager);
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
            Create(); //To add the Director and Country lists back when The Result failed, else the list would be completely empty
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
        public IActionResult Update(MovieViewModel model, int id)
        {
            var modelId = _movieClient.GetMovieById(id).Result;
            var response = _movieClient.UpdateMovie(model);
            if (response.Result)
            {
                return RedirectToAction("Index");
            }
            Update(id);
            return View(modelId);
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
