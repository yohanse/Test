
using Application.DTOs.Cinema;
using Application.Features.Cinemas.Requests.Commands;
using Application.Features.Cinemas.Requests.Queries;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IMediator _mediator;
        public BookController(IMediator mediator)
        {
            _mediator = mediator;
        }
        // GET: api/<CinemasController>
        [HttpGet]
        public async Task<ActionResult<List<Book>>> Get()
        {
            var books = await _mediator.Send(new GetBookListRequest());
            return Ok(books);
        }

        // GET api/<CinemasController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Movie>> Get(int id)
        {
            var book = await _mediator.Send(new GetBookDetailRequest { Id = id });
            return Ok(book);
        }

        // POST api/<CinemasController>
        [HttpPost]
        public async Task<ActionResult<Boook>> Post([FromBody] CreatBookDto book)
        {
            var command = new CreateBookCommand { CreateBookDto = book };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        // PUT api/<CinemasController>
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] UpdateBookDto book)
        {
            var command = new UpdateBookCommand { UpdateBookDto = Cinema };
            await _mediator.Send(command);
            return NoContent();
        }

        // DELETE api/<CinemasController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Book>> Delete(int Id)
        {
            var command = new DeleteBookCommand { Id = Id };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        public async Task<ActionResult<List<Book>>> Search(string title)
        {
            var books = await _mediator.Send(new GetBookListByTitleRequest());
            return Ok(books);
        }
    }
}