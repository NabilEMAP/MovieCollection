using MovieCollection.Common.DTO.Movies;
using MovieCollection.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCollection.BLL.Interfaces
{
    public interface IMoviesService
    {
        public Task<IEnumerable<MovieDetailDTO>> GetMovieDetails();
        public Task<IEnumerable<MovieDTO>> GetMovies();
        public Task<MovieDetailDTO> GetMovieByTitle(string title);
        public Task<MovieDetailDTO> GetById(int id);
        public Task<MovieDetailDTO> Add(CreateMovieDTO movie);
        public Task<MovieDetailDTO> Update(int id, UpdateMovieDTO movie);
        public Task<int> Delete(int id);
    }
}
