using Application.DTOs.Common;
using Application.DTOs.Movie;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Cinema
{
     public class UpdateBookDto : BaseDto, IBookDto
    {
        public string title { get; set; } = "";
        public Genere genere {get; set;}
        public DateTime releaseYear {get; set;}
        public int UserId { get; set; }
    }
}
