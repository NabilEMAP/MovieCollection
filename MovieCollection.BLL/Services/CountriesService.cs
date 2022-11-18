using MovieCollection.BLL.Interfaces;
using MovieCollection.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCollection.BLL.Services
{
    public class CountriesService : ICountriesService
    {
        public Task<Country> Add(Country country)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Country> GetAll(int pageNr, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<Country> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Country> Update(Country country)
        {
            throw new NotImplementedException();
        }
    }
}
