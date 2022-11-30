using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieCollection.BLL.Interfaces;
using MovieCollection.DAL.Contexts;
using MovieCollection.DAL.Models;
using System;

namespace MovieCollection.API.Controllers
{
    public class CountriesController : Controller
    {
        /*
        //private readonly ICountriesService _db;

        //public CountriesController(ICountriesService countriesService)
        //{
        //    _db = countriesService;
        //}

        private readonly ApplicationDbContext _db;

        public CountriesController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Country> objList = _db.Countries;
            return View(objList);
        }

        // GET-Create
        public IActionResult Create()
        {
            return View();
        }

        // POST-Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Country obj)
        {
            if (ModelState.IsValid)
            {
                _db.Countries.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        // GET-Delete
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Countries.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        // POST-Delete
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.Countries.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Countries.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }

        // GET-Update
        public IActionResult Update(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Countries.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        // POST-Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Country obj)
        {
            if (ModelState.IsValid)
            {
                _db.Countries.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }
        */
    }
}
