using AutoMapper;
using MovieCollection.BLL.DTO.Users;
using MovieCollection.Common.DTO.Countries;
using MovieCollection.Common.DTO.Directors;
using MovieCollection.Common.DTO.Genres;
using MovieCollection.Common.DTO.Movies;
using MovieCollection.Common.DTO.Users;
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

            CreateMap<Country, CountryDTO>().ReverseMap();
            CreateMap<Country, CountryDTO>().ReverseMap();
            CreateMap<Country, CreateCountryDTO>().ReverseMap();
            CreateMap<Country, UpdateCountryDTO>().ReverseMap();

            CreateMap<Director, DirectorDTO>().ReverseMap();
            CreateMap<Director, DirectorDetailDTO>().ReverseMap();
            CreateMap<Director, CreateDirectorDTO>().ReverseMap();
            CreateMap<Director, UpdateDirectorDTO>().ReverseMap();

            CreateMap<Movie, MovieDTO>().ReverseMap();
            CreateMap<Movie, MovieDetailDTO>().ReverseMap();
            CreateMap<Movie, CreateMovieDTO>().ReverseMap();
            CreateMap<Movie, UpdateMovieDTO>().ReverseMap();

            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<User, UserDetailDTO>().ReverseMap();
            CreateMap<User, CreateUserDTO>().ReverseMap();
            CreateMap<User, UpdateUserDTO>().ReverseMap();
        }
    }
}
