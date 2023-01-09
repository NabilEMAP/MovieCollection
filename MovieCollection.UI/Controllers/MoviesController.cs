using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MovieCollection.UI.Controllers.MovieCollectionClient;
using MovieCollection.UI.Models;
using MovieCollection.UI.Views.Shared.Components.SearchBar;
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

        public IActionResult Index(string SearchText = "", int pg = 1, int pageSize = 10)
        {
            var modelList = _movieClient.GetMovies().Result;
            if (SearchText != "" && SearchText != null)
            {
                modelList = modelList.Where(p =>
                    p.Title.Contains(SearchText) ||
                    p.ReleaseDate.ToString().Contains(SearchText) ||
                    p.Director.Fullname.Contains(SearchText) ||
                    p.Country.Name.Contains(SearchText)
                    ).ToList();
            }
            else
                modelList = modelList.ToList();

            //const int pageSize = 10;
            if (pg < 1) { pg = 1; }

            int recsCount = modelList.Count();
            int recSkip = (pg - 1) * pageSize;

            var retList = modelList.Skip(recSkip).Take(pageSize).ToList();
            SPager SearchPager = new SPager(recsCount, pg, pageSize) { Action = "Index", Controller = "Movies", SearchText = SearchText };
            ViewBag.SearchPager = SearchPager;

            this.ViewBag.PageSizes = GetPageSizes(pageSize);

            return View(retList);
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

        private List<SelectListItem> GetPageSizes(int selectedPageSize = 10)
        {
            var pagesSizes = new List<SelectListItem>();

            if (selectedPageSize == 5)
                pagesSizes.Add(new SelectListItem("5", "5", true));
            else
                pagesSizes.Add(new SelectListItem("5", "5"));

            for (int lp = 10; lp <= 100; lp += 10)
            {
                if (lp == selectedPageSize)
                { pagesSizes.Add(new SelectListItem(lp.ToString(), lp.ToString(), true)); }
                else
                    pagesSizes.Add(new SelectListItem(lp.ToString(), lp.ToString()));
            }
            return pagesSizes;
        }
    }
}
