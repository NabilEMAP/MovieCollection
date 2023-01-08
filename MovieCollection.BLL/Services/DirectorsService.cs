using AutoMapper;
using MovieCollection.BLL.Interfaces;
using MovieCollection.Common.DTO.Directors;
using MovieCollection.DAL.Models;
using MovieCollection.DAL.UOW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCollection.BLL.Services
{
    public class DirectorsService : IDirectorsService
    {
        public readonly IUnitOfWork _uow;
        public readonly IMapper _mapper;

        public DirectorsService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<DirectorDetailDTO> Add(CreateDirectorDTO entity)
        {
            var director = _mapper.Map<Director>(entity);
            await _uow.DirectorsRepository.Add(director);
            await _uow.Save();
            return _mapper.Map<DirectorDetailDTO>(director);
        }

        public async Task<int> Delete(int id)
        {
            var toDeleteDirector = await _uow.DirectorsRepository.GetByIdAsync(id);
            if (toDeleteDirector == null)
            {
                throw new KeyNotFoundException("This director does not exist.");
            }
            _uow.DirectorsRepository.Delete(toDeleteDirector);
            _uow.Save();
            return 0;
        }

        public async Task<IEnumerable<DirectorDetailDTO>> GetAll()
        {
            var directors = await _uow.DirectorsRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<DirectorDetailDTO>>(directors);
        }

        public async Task<DirectorDetailDTO> GetById(int id)
        {
            var director = await _uow.DirectorsRepository.GetByIdAsync(id);
            return _mapper.Map<DirectorDetailDTO>(director);
        }

        public async Task<DirectorDetailDTO> Update(int id, UpdateDirectorDTO entity)
        {
            var directorFromRequest = _mapper.Map<Director>(entity);
            var directorToUpdate = await _uow.DirectorsRepository.GetByIdAsync(id);

            if (directorToUpdate == null)
            {
                throw new KeyNotFoundException("This director does not exists");
            }

            directorToUpdate.FirstName = directorFromRequest.FirstName;
            directorToUpdate.LastName = directorFromRequest.LastName;
            directorToUpdate.DateOfBirth = directorFromRequest.DateOfBirth;
            directorToUpdate.Nationality = directorFromRequest.Nationality;
            directorToUpdate.IsActive = directorFromRequest.IsActive;
            directorToUpdate.PicturePath = directorFromRequest.PicturePath;

            await _uow.DirectorsRepository.Update(directorToUpdate);
            await _uow.Save();
            return _mapper.Map<DirectorDetailDTO>(directorToUpdate);
        }
    }
}
