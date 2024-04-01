using Application.DTOs.Cinema;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contracts
{
    public interface IBookREpository : IGenericRepository<Book>{
        Task<IReadOnlyList<BookDto>> Search(string title); 
    }
}
