using MovieCollection.UI.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace MovieCollection.UI.Controllers.MovieCollectionClient
{
    public class MovieClient : IMovieClient
    {
        private readonly HttpClient _httpClient;
        private readonly Uri _baseAddress = new Uri("https://localhost:8001/api");
        private IEnumerable<MovieViewModel> _movies;
        private IEnumerable<CountryViewModel> _countries;
        private IEnumerable<DirectorViewModel> _directors;

        public MovieClient()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = _baseAddress;
        }

        private IEnumerable<MovieViewModel> Movies
        {
            get { return _movies; }
            set
            {
                if (_movies is null)
                {
                    _movies = value;
                }
            }
        }

        private IEnumerable<CountryViewModel> Countries
        {
            get { return _countries; }
            set
            {
                if (_countries is null)
                {
                    _countries = value;
                }
            }
        }

        private IEnumerable<DirectorViewModel> Directors
        {
            get { return _directors; }
            set
            {
                if (_directors is null)
                {
                    _directors = value;
                }
            }
        }

        public async Task<IEnumerable<MovieViewModel>> GetMovies()
        {
            HttpResponseMessage movieResponse = _httpClient.GetAsync(_baseAddress + "/Movies").Result;
            if (movieResponse.IsSuccessStatusCode)
            {
                string movieData = movieResponse.Content.ReadAsStringAsync().Result;
                _movies = JsonConvert.DeserializeObject<List<MovieViewModel>>(movieData);
            }
            return _movies;
        }

        public async Task<MovieViewModel> GetMovieById(int id)
        {
            MovieViewModel model = new();
            HttpResponseMessage response = _httpClient.GetAsync(_httpClient.BaseAddress + "/Movies/" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                model = JsonConvert.DeserializeObject<MovieViewModel>(data);
            }
            return model;
        }

        public async Task<IEnumerable<CountryViewModel>> GetCountries()
        {
            HttpResponseMessage countryResponse = _httpClient.GetAsync(_baseAddress + "/Countries").Result;
            if (countryResponse.IsSuccessStatusCode)
            {
                string countryData = countryResponse.Content.ReadAsStringAsync().Result;
                _countries = JsonConvert.DeserializeObject<List<CountryViewModel>>(countryData);
            }
            return _countries;
        }

        public async Task<IEnumerable<DirectorViewModel>> GetDirectors()
        {
            HttpResponseMessage directorResponse = _httpClient.GetAsync(_baseAddress + "/Directors").Result;
            if (directorResponse.IsSuccessStatusCode)
            {
                string directorData = directorResponse.Content.ReadAsStringAsync().Result;
                _directors = JsonConvert.DeserializeObject<List<DirectorViewModel>>(directorData);
            }
            return _directors;
        }

        public async Task<bool> CreateMovie(MovieViewModel model)
        {
            string data = JsonConvert.SerializeObject(model);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = _httpClient.PostAsync(_baseAddress + "/Movies", content).Result;
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        public async Task<bool> UpdateMovie(MovieViewModel model)
        {
            string data = JsonConvert.SerializeObject(model);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = _httpClient.PutAsync(_httpClient.BaseAddress + "/Movies?id=" + model.Id, content).Result;
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        public async Task<bool> DeleteMovie(MovieViewModel model)
        {
            HttpResponseMessage response = _httpClient.DeleteAsync(_httpClient.BaseAddress + "/Movies?id=" + model.Id).Result;
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }


    }
}
