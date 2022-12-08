using AutoMapper;
using MovieCollection.Common.DTO.Genres;
using MovieCollection.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCollection.BLL
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Genre, GenreDTO>().ReverseMap();
            CreateMap<Genre, CreateGenreDTO>().ReverseMap();
            CreateMap<Genre, UpdateGenreDTO>().ReverseMap();
        }

    }
}
