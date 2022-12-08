using AutoMapper;
using MovieCollection.BLL.Interfaces;
using MovieCollection.Common.DTO.Genres;
using MovieCollection.DAL.Models;
using MovieCollection.DAL.UOW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCollection.BLL.Services
{
    public class GenresService : IGenresService
    {
        public readonly IUnitOfWork _uow;
        public readonly IMapper _mapper;

        public GenresService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<GenreDTO> Add(CreateGenreDTO entity)
        {
            var genre = _mapper.Map<Genre>(entity);
            await _uow.GenresRepository.Add(genre);
            await _uow.Save();
            return _mapper.Map<GenreDTO>(genre);
        }

        public async Task<int> Delete(int id)
        {
            var toDeleteGenre = await _uow.GenresRepository.GetByIdAsync(id);
            if (toDeleteGenre == null)
            {
                throw new KeyNotFoundException("This genre does not exists");
            }

            _uow.GenresRepository.Delete(toDeleteGenre);
            _uow.Save();
            return 0;
        }

        public async Task<IEnumerable<GenreDTO>> GetAll()
        {
            var genres = await _uow.GenresRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<GenreDTO>>(genres);
        }

        public async Task<GenreDTO> GetById(int id)
        {
            var genre = await _uow.GenresRepository.GetByIdAsync(id);
            return _mapper.Map<GenreDTO>(genre);
        }

        public async Task<GenreDTO> Update(int id, UpdateGenreDTO entity)
        {
            var genreFromRequest = _mapper.Map<Genre>(entity);
            var genreToUpdate = await _uow.GenresRepository.GetByIdAsync(id);

            if (genreToUpdate == null)
            {
                throw new KeyNotFoundException("This genre does not exists");
            }

            genreToUpdate.Name = genreFromRequest.Name;

            await _uow.GenresRepository.Update(genreToUpdate);
            await _uow.Save();
            return _mapper.Map<GenreDTO>(genreToUpdate);
        }
    }
}
