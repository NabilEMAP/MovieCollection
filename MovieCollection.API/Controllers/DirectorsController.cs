using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieCollection.BLL.Interfaces;
using MovieCollection.DAL.Contexts;
using MovieCollection.DAL.Models;
using System;

namespace MovieCollection.API.Controllers
{
    public class DirectorsController : Controller
    {
        //private readonly IDirectorsService _db;

        //public DirectorsController(IDirectorsService directorsService)
        //{
        //    _db = directorsService;
        //}

        private readonly ApplicationDbContext _db;

        public DirectorsController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Director> objList = _db.Directors;
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
        public IActionResult Create(Director obj)
        {
            if (ModelState.IsValid)
            {
                _db.Directors.Add(obj);
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
            var obj = _db.Directors.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        // POST-Delete
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.Directors.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Directors.Remove(obj);
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
            var obj = _db.Directors.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        // POST-Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Director obj)
        {
            if (ModelState.IsValid)
            {
                _db.Directors.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }
    }
}
