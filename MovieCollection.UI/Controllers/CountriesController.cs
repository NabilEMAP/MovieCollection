using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieCollection.DAL.Contexts;
using MovieCollection.DAL.Models;
using System;

namespace MovieCollection.UI.Controllers
{
    public class CountriesController : Controller
    {
        Uri baseAddress = new Uri("https://localhost:8001/api");
        HttpClient client;

        public CountriesController()
        {
            client = new HttpClient();
            client.BaseAddress = baseAddress;
        }

    }
}
