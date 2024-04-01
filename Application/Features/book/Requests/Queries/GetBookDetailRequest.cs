using Application.DTOs.Cinema;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Cinemas.Requests.Queries
{
    public class GetBookDetailRequest : IRequest<BookDto>
    {
        public int Id { get; set; }
    }
}
