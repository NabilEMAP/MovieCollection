using MovieCollection.Common.DTO.Directors;
using MovieCollection.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCollection.BLL.Interfaces
{
    public interface IDirectorsService
    {
        public Task<IEnumerable<DirectorDetailDTO>> GetDirectorDetails();
        public Task<IEnumerable<DirectorDTO>> GetDirectors();
        public Task<DirectorDetailDTO> GetById(int id);
        public Task<DirectorDetailDTO> Add(CreateDirectorDTO director);
        public Task<DirectorDetailDTO> Update(int id, UpdateDirectorDTO director);
        public Task<int> Delete(int id);
    }
}
