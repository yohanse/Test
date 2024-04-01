using Application.Contracts;
using Application.DTOs.Cinema;
using Application.Features.Cinemas.Requests.Queries;
using Application.Features.Movies.Requests.Queries;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Cinemas.Handlers.Queries
{
    public class GetBookListRequestHandler : IRequestHandler<GetBookListRequest, List<BookDto>>
    {
        private readonly IBookREpository _Repository;
        private readonly IMapper _mapper;

        public GetBookListRequestHandler(IBookREpository Repository, IMapper mapper)
        {
            _Repository = Repository;
            _mapper = mapper;
        }

        

        public async Task<List<BookDto>> Handle(GetBookListRequest request, CancellationToken cancellationToken)
        {
            var books = await _Repository.GetAll();
            return _mapper.Map<List<BookDto>>(books);
        }
    }
}
