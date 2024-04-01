using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Cinema.Validators
{
    public class CreateBookDtoValidator : AbstractValidator<BookDto>
    {
        public CreateBookDtoValidator()
        {
            Include(new IBookDtoValidator());
        }
    }
}
