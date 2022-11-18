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
        public IEnumerable<Director> GetAll(int pageNr, int pageSize);
        public Task<Director> GetById(int id);
        public Task<Director> Add(Director director);
        public Task Delete(int id);
        public Task<Director> Update(Director director);
    }
}
