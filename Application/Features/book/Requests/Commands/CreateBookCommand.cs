using Application.DTOs.Cinema;
using Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Cinemas.Requests.Commands
{
    public class CreateBookCommand : IRequest<BaseCommandResponse>
    {
        public CreateBookDto CreateBookDto { get; set; }
    }
}
