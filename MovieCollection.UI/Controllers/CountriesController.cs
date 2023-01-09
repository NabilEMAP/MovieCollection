using Microsoft.AspNetCore.Mvc;
using MovieCollection.UI.Models;
using Newtonsoft.Json;
using System;
using System.Text;
using MovieCollection.UI.Views.Shared.Components.SearchBar;
using Microsoft.AspNetCore.Mvc.Rendering;

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

        public IActionResult Index(string SearchText = "", int pg = 1, int pageSize = 5)
        {
            List<CountryViewModel> modelList = new List<CountryViewModel>();
            HttpResponseMessage response = client.GetAsync(baseAddress + "/Countries").Result;
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                modelList = JsonConvert.DeserializeObject<List<CountryViewModel>>(data);
            }
            if (SearchText != "" && SearchText != null)
            {
                modelList = modelList.Where(p => p.Name.Contains(SearchText)).ToList();
            }
            else
                modelList = modelList.ToList();

            //const int pageSize = 10;
            if (pg < 1) { pg = 1; }

            int recsCount = modelList.Count();
            int recSkip = (pg - 1) * pageSize;

            var retList = modelList.Skip(recSkip).Take(pageSize).ToList();            
            SPager SearchPager = new SPager(recsCount, pg, pageSize) { Action = "Index", Controller = "Countries", SearchText = SearchText };
            ViewBag.SearchPager = SearchPager;

            this.ViewBag.PageSizes = GetPageSizes(pageSize);

            return View(retList);
        }

        // GET-Create
        public IActionResult Create()
        {
            return View();
        }

        // POST-Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CountryViewModel model)
        {
            string data = JsonConvert.SerializeObject(model);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync(baseAddress + "/Countries", content).Result;
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        // GET-Update
        public IActionResult Update(int id)
        {
            CountryViewModel model = new CountryViewModel();
            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "/Countries/" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                model = JsonConvert.DeserializeObject<CountryViewModel>(data);
            }
            return View(model);
        }

        // POST-Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(CountryViewModel model)
        {
            string data = JsonConvert.SerializeObject(model);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PutAsync(client.BaseAddress + "/Countries?id=" + model.Id, content).Result;
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }

        //GET-Delete
        public IActionResult Delete(int id)
        {
            CountryViewModel model = new CountryViewModel();
            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "/Countries/" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                model = JsonConvert.DeserializeObject<CountryViewModel>(data);
            }
            return View(model);
        }

        // POST-Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(CountryViewModel model)
        {
            string data = JsonConvert.SerializeObject(model);
            HttpResponseMessage response = client.DeleteAsync(client.BaseAddress + "/Countries?id=" + model.Id).Result;
            if (response.IsSuccessStatusCode)
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
