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
        public IEnumerable<Genre> GetAll(int pageNr, int pageSize);
        public Task<Genre> GetById(int id);
        public Task<Genre> Add(Genre genre);
        public Task Delete(int id);
        public Task<Genre> Update(Genre genre);
    }
}
