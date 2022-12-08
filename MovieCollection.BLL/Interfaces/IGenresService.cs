using MovieCollection.Common.DTO.Genres;
using MovieCollection.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCollection.BLL.Interfaces
{
    public interface IGenresService
    {
        public Task<IEnumerable<GenreDTO>> GetAll();
        public Task<GenreDTO> GetById(int id);
        public Task<GenreDTO> Add(CreateGenreDTO genre);
        public Task<GenreDTO> Update(int id, UpdateGenreDTO genre);
        public Task<int> Delete(int id);
    }
}
