using MovieCollection.Common.DTO.Countries;
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
        public Task<IEnumerable<CountryDTO>> GetAll();
        public Task<CountryDTO> GetById(int id);
        public Task<IEnumerable<CountryDTO>> GetCountryByName(string name);
        public Task<CountryDTO> Add(CreateCountryDTO country);
        public Task<CountryDTO> Update(int id, UpdateCountryDTO country);
        public Task<int> Delete(int id);
    }
}
