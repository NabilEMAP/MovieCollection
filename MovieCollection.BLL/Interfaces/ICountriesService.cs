using MovieCollection.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCollection.BLL.Interfaces
{
    public interface ICountriesService
    {
        public IEnumerable<Country> GetAll(int pageNr, int pageSize);
        public Task<Country> GetById(int id);
        public Task<Country> Add(Country country);
        public Task Delete(int id);
        public Task<Country> Update(Country country);
    }
}
