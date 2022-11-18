﻿using Microsoft.EntityFrameworkCore;
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
        private readonly ApplicationDbContext context;

        public CountriesRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<Country> GetByName(string name)
        {
            return await context.Countries.Where(x => x.Name == name).FirstOrDefaultAsync();
        }
    }
}
