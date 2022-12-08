using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieCollection.DAL.Models;
using MovieCollection.UI.Models;
using Newtonsoft.Json;
using System;
using System.Text;
using System.Text.Json.Serialization;
using System.Net.Http.Headers;

namespace MovieCollection.API.Controllers
{
    public class GenresController : Controller
    {
        string baseURL = "https://localhost:8001/api/";

        public async Task<IActionResult> Index()
        {
            IList<GenreViewModel> genre = new List<GenreViewModel>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseURL);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                
                HttpResponseMessage getData = await client.GetAsync("Genres");

                if (getData.IsSuccessStatusCode)
                {
                    string results = getData.Content.ReadAsStringAsync().Result;
                    genre = JsonConvert.DeserializeObject<List<GenreViewModel>>(results);
                }
                else
                {
                    Console.WriteLine("Error calling WebAPI");
                }
                ViewData.Model = genre;
            }
            return View();
        }

        public async Task<IActionResult> Create(GenreViewModel genre)
        {
            GenreViewModel obj = new GenreViewModel()
            {
                Name = genre.Name,
            };

            if (genre.Name != null)
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(baseURL + "Genres/");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage getData = await client.PostAsJsonAsync<GenreViewModel>("addGenre", obj);

                    if (getData.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index", "Genres");
                    }
                    else
                    {
                        Console.WriteLine("Error calling WebAPI");
                    }
                }
            }
            return View();
        }

        public async Task<IActionResult> Update()
        {
            return View();
        }

        public async Task<IActionResult> Delete()
        {
            return View();
        }
    }
}
