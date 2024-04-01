using Application.DTOs.Cinema;
using Application.DTOs.Movie;
using AutoMapper;
using Domain;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Book, CreateBookDto>().ReverseMap();
            CreateMap<Book, BookDto>().ReverseMap();

            CreateMap<User, UserDto>().ReverseMap();
        }
    }
}
