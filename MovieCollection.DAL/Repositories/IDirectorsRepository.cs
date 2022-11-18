using MovieCollection.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCollection.DAL.Repositories
{
    public interface IDirectorsRepository : IGenericRepository<Director>
    {
        Director GetByLastName(string lastName);
    }
}
