using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Cinemas.Requests.Commands
{
    public class DeleteBookCommand : IRequest
    {
        public int Id { get; set; }
    }
}
