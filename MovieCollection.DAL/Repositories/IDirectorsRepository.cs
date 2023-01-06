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
        Task<Director> GetByNationality(string nationality);
        Task<Director> GetByLastName(string lastName);
        Task<Director> GetByFirstName(string firstName);
    }
}
