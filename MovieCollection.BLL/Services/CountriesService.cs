using AutoMapper;
using MovieCollection.BLL.Interfaces;
using MovieCollection.Common.DTO.Countries;
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
    public class CountriesService : ICountriesService
    {
        public readonly IUnitOfWork _uow;
        public readonly IMapper _mapper;

        public CountriesService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<CountryDTO> Add(CreateCountryDTO entity)
        {
            var country = _mapper.Map<Country>(entity);
            await _uow.CountriesRepository.Add(country);
            await _uow.Save();
            return _mapper.Map<CountryDTO>(country);
        }

        public async Task<int> Delete(int id)
        {
            var toDeleteCountry = await _uow.CountriesRepository.GetByIdAsync(id);
            if(toDeleteCountry == null)
            {
                throw new KeyNotFoundException("This country does not exist.");
            }
            _uow.CountriesRepository.Delete(toDeleteCountry);
            _uow.Save();
            return 0;
        }

        public async Task<IEnumerable<CountryDTO>> GetAll()
        {
            var countries = await _uow.CountriesRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<CountryDTO>>(countries);
        }

        public async Task<CountryDTO> GetById(int id)
        {
            var countries = await _uow.CountriesRepository.GetByIdAsync(id);
            return _mapper.Map<CountryDTO>(countries);
        }

        public async Task<CountryDTO> GetCountryByName(string name)
        {
            var countries = await _uow.CountriesRepository.GetCountryByName(name);
            return _mapper.Map<CountryDTO>(countries);
        }

        public async Task<CountryDTO> Update(int id, UpdateCountryDTO entity)
        {
            var countryFromRequest = _mapper.Map<Country>(entity);
            var countryToUpdate = await _uow.CountriesRepository.GetByIdAsync(id);

            if(countryToUpdate == null)
            {
                throw new KeyNotFoundException("This country does not exist.");
            }

            countryToUpdate.Name = countryFromRequest.Name;

            await _uow.CountriesRepository.Update(countryToUpdate);
            await _uow.Save();
            return _mapper.Map<CountryDTO>(countryToUpdate);
        }
    }
}
