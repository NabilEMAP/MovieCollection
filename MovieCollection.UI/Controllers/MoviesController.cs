using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MovieCollection.BLL.Interfaces;
using MovieCollection.UI.Models;
using Newtonsoft.Json;
using System;
using System.Text;

namespace MovieCollection.UI.Controllers
{
    public class MoviesController : Controller
    {
        Uri baseAddress = new Uri("https://localhost:8001/api");
        HttpClient client;

        public MoviesController()
        {
            client = new HttpClient();
            client.BaseAddress = baseAddress;
        }

        public IActionResult Index()
        {
            List<MovieViewModel> modelList = new List<MovieViewModel>();
            HttpResponseMessage response = client.GetAsync(baseAddress + "/Movies").Result;
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                modelList = JsonConvert.DeserializeObject<List<MovieViewModel>>(data);
            }
            return View(modelList);
        }

        // GET-Create
        public IActionResult Create()
        {
            List<CountryViewModel> countryList = new List<CountryViewModel>();
            List<DirectorViewModel> directorList = new List<DirectorViewModel>();
            HttpResponseMessage countryResponse = client.GetAsync(baseAddress + "/Countries").Result;
            HttpResponseMessage directorResponse = client.GetAsync(baseAddress + "/Directors").Result;
            if (countryResponse.IsSuccessStatusCode && directorResponse.IsSuccessStatusCode)
            {
                string countryData = countryResponse.Content.ReadAsStringAsync().Result;
                string directorData = directorResponse.Content.ReadAsStringAsync().Result;
                countryList = JsonConvert.DeserializeObject<List<CountryViewModel>>(countryData);
                directorList = JsonConvert.DeserializeObject<List<DirectorViewModel>>(directorData);
            }
            ViewData["CountryId"] = new SelectList(countryList, "Id", "Name");
            ViewData["DirectorId"] = new SelectList(directorList, "Id", "Fullname");
            return View();
        }

        // POST-Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(MovieViewModel model)
        {
            string data = JsonConvert.SerializeObject(model);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync(baseAddress + "/Movies", content).Result;
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        // GET-Update
        public IActionResult Update(int id)
        {
            MovieViewModel model = new MovieViewModel();
            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "/Movies/" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                model = JsonConvert.DeserializeObject<MovieViewModel>(data);
            }
            return View(model);
        }

        // POST-Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(MovieViewModel model)
        {
            string data = JsonConvert.SerializeObject(model);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PutAsync(client.BaseAddress + "/Movies?id=" + model.Id, content).Result;
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }

        //GET-Delete
        public IActionResult Delete(int id)
        {
            MovieViewModel model = new MovieViewModel();
            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "/Movies/" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                model = JsonConvert.DeserializeObject<MovieViewModel>(data);
            }
            return View(model);
        }

        // POST-Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(MovieViewModel model)
        {
            string data = JsonConvert.SerializeObject(model);
            HttpResponseMessage response = client.DeleteAsync(client.BaseAddress + "/Movies?id=" + model.Id).Result;
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
