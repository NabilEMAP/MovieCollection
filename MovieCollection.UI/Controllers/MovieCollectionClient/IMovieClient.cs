using MovieCollection.UI.Models;

namespace MovieCollection.UI.Controllers.MovieCollectionClient
{
    public interface IMovieClient
    {
        public Task<IEnumerable<MovieViewModel>> GetMovies();
        public Task<MovieViewModel> GetMovieById(int id);
        public Task<IEnumerable<CountryViewModel>> GetCountries();
        public Task<IEnumerable<DirectorViewModel>> GetDirectors();
        public Task<IEnumerable<GenreViewModel>> GetGenres();
        public Task<bool> CreateMovie(MovieViewModel movie);
        public Task<bool> UpdateMovie(MovieViewModel movie);
        public Task<bool> DeleteMovie(MovieViewModel movie);
    }
}
