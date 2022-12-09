using Microsoft.AspNetCore.Mvc;
using MovieCollection.UI.Models;
using Newtonsoft.Json;

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

        public IActionResult Create()
        {

            return View();
        }
    }
}
