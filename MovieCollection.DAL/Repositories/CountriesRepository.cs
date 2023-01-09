using Microsoft.EntityFrameworkCore;
using MovieCollection.DAL.Contexts;
using MovieCollection.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MovieCollection.DAL.Repositories
{
    public class CountriesRepository : GenericRepository<Country>, ICountriesRepository
    {

        public CountriesRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Country>> GetCountryByName(string name)
        {
            //Stored Procedure
            return await _context.Countries.FromSql($"GetCountryByName {name}").ToListAsync();
        }
    }
}
