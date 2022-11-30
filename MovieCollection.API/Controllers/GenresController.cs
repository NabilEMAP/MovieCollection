using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieCollection.BLL.Interfaces;
using MovieCollection.DAL.Contexts;
using MovieCollection.DAL.Models;
using System;

namespace MovieCollection.API.Controllers
{
    public class GenresController : Controller
    {
        /*
        //private readonly IGenresService _db;

        //public GenresController(IGenresService genresService)
        //{
        //    _db = genresService;
        //}

        private readonly ApplicationDbContext _db;

        public GenresController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Genre> objList = _db.Genres;
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
        public IActionResult Create(Genre obj)
        {
            if (ModelState.IsValid)
            {
                _db.Genres.Add(obj);
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
            var obj = _db.Genres.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        // POST-Delete
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.Genres.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Genres.Remove(obj);
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
            var obj = _db.Genres.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        // POST-Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Genre obj)
        {
            if (ModelState.IsValid)
            {
                _db.Genres.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }
        */
    }
}
