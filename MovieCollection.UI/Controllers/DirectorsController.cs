using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieCollection.DAL.Contexts;
using MovieCollection.DAL.Models;
using MovieCollection.UI.Models;
using Newtonsoft.Json;
using System;
using System.Text;

namespace MovieCollection.UI.Controllers
{
    public class DirectorsController : Controller
    {
        Uri baseAddress = new Uri("https://localhost:8001/api");
        HttpClient client;

        public DirectorsController()
        {
            client = new HttpClient();
            client.BaseAddress = baseAddress;
        }

        public IActionResult Index()
        {
            List<DirectorViewModel> modelList = new List<DirectorViewModel>();
            HttpResponseMessage response = client.GetAsync(baseAddress + "/Directors").Result;
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                modelList = JsonConvert.DeserializeObject<List<DirectorViewModel>>(data);
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
        public IActionResult Create(DirectorViewModel model)
        {
            string data = JsonConvert.SerializeObject(model);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync(baseAddress + "/Directors", content).Result;
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        // GET-Update
        public IActionResult Update(int id)
        {
            DirectorViewModel model = new DirectorViewModel();
            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "/Directors/" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                model = JsonConvert.DeserializeObject<DirectorViewModel>(data);
            }
            return View(model);
        }

        // POST-Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(DirectorViewModel model)
        {
            string data = JsonConvert.SerializeObject(model);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PutAsync(client.BaseAddress + "/Directors?id=" + model.Id, content).Result;
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }

        //GET-Delete
        public IActionResult Delete(int id)
        {
            DirectorViewModel model = new DirectorViewModel();
            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "/Directors/" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                model = JsonConvert.DeserializeObject<DirectorViewModel>(data);
            }
            return View(model);
        }

        // POST-Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(DirectorViewModel model)
        {
            string data = JsonConvert.SerializeObject(model);
            HttpResponseMessage response = client.DeleteAsync(client.BaseAddress + "/Directors?id=" + model.Id).Result;
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
