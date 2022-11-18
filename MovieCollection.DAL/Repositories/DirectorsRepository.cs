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
    public class DirectorsRepository : GenericRepository<Director>, IDirectorsRepository
    {
        private readonly ApplicationDbContext context;

        public DirectorsRepository(ApplicationDbContext context) : base(context)
        {
        }

        public Director GetByLastName(string lastName)
        {
            return context.Directors.FirstOrDefault(s => s.LastName == lastName);
        }
    }
}
