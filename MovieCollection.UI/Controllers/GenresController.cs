using Microsoft.AspNetCore.Mvc;
using MovieCollection.UI.Models;
using Newtonsoft.Json;
using System.Text;

namespace MovieCollection.API.Controllers
{
    public class GenresController : Controller
    {
        Uri baseAddress = new Uri("https://localhost:8001/api");
        HttpClient client;

        public GenresController()
        {
            client = new HttpClient();
            client.BaseAddress = baseAddress;
        }

        public IActionResult Index()
        {
            List<GenreViewModel> modelList = new List<GenreViewModel>();
            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "/Genres").Result;
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                modelList = JsonConvert.DeserializeObject<List<GenreViewModel>>(data);
            }
            return View(modelList);
        }

        // GET-Create
        public IActionResult Create()
        {
            return View();
        }

        // POST-Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(GenreViewModel model)
        {
            string data = JsonConvert.SerializeObject(model);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync(client.BaseAddress + "/Genres", content).Result;
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        // GET-Update
        public IActionResult Update(int id)
        {
            GenreViewModel model = new GenreViewModel();
            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "/Genres/" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                model = JsonConvert.DeserializeObject<GenreViewModel>(data);
            }
            return View(model);
        }

        // POST-Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(GenreViewModel model)
        {
            string data = JsonConvert.SerializeObject(model);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PutAsync(client.BaseAddress + "/Genres?id=" + model.Id, content).Result;
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }

        // GET-Delete
        public IActionResult Delete(int id)
        {
            GenreViewModel model = new GenreViewModel();
            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "/Genres/" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                model = JsonConvert.DeserializeObject<GenreViewModel>(data);
            }
            return View(model);
        }

        // POST-Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(GenreViewModel model)
        {
            string data = JsonConvert.SerializeObject(model);
            HttpResponseMessage response = client.DeleteAsync(client.BaseAddress + "/Genres?id=" + model.Id).Result;
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
