using AutoMapper;
using MovieCollection.BLL.Interfaces;
using MovieCollection.Common.DTO.Genres;
using MovieCollection.Common.DTO.Movies;
using MovieCollection.DAL.Models;
using MovieCollection.DAL.UOW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCollection.BLL.Services
{
    public class MoviesService : IMoviesService
    {
        public readonly IUnitOfWork _uow;
        public readonly IMapper _mapper;

        public MoviesService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<MovieDetailDTO> Add(CreateMovieDTO entity)
        {
            var movie = _mapper.Map<Movie>(entity);
            await _uow.MoviesRepository.Add(movie);
            await _uow.Save();
            return _mapper.Map<MovieDetailDTO>(movie);
        }

        public async Task<int> Delete(int id)
        {
            var toDeleteMovie = await _uow.MoviesRepository.GetByIdAsync(id);
            if (toDeleteMovie == null)
            {
                throw new KeyNotFoundException("This movie does not exist.");
            }
            _uow.MoviesRepository.Delete(toDeleteMovie);
            _uow.Save();
            return 0;
        }

        public async Task<IEnumerable<MovieDetailDTO>> GetMovieDetails()
        {
            var movies = await _uow.MoviesRepository.GetAllMoviesAsync();
            return _mapper.Map<IEnumerable<MovieDetailDTO>>(movies);
        }

        public async Task<IEnumerable<MovieDTO>> GetMovies()
        {
            var movies = await _uow.MoviesRepository.GetAllMoviesAsync();
            return _mapper.Map<IEnumerable<MovieDTO>>(movies);
        }

        public async Task<MovieDetailDTO> GetById(int id)
        {
            var movie = await _uow.MoviesRepository.GetByIdAsync(id);
            return _mapper.Map<MovieDetailDTO>(movie);
        }

        public async Task<MovieDetailDTO> Update(int id, UpdateMovieDTO entity)
        {
            var movieFromRequest = _mapper.Map<Movie>(entity);
            var movieToUpdate = await _uow.MoviesRepository.GetByIdAsync(id);

            if (movieToUpdate == null)
            {
                throw new KeyNotFoundException("This movie does not exists");
            }

            movieToUpdate.Title = movieFromRequest.Title;
            movieToUpdate.ReleaseDate = movieFromRequest.ReleaseDate;
            movieToUpdate.DirectorId = movieFromRequest.DirectorId;
            movieToUpdate.CountryId = movieFromRequest.CountryId;

            await _uow.MoviesRepository.Update(movieToUpdate);
            await _uow.Save();
            return _mapper.Map<MovieDetailDTO>(movieToUpdate);
        }
    }
}
