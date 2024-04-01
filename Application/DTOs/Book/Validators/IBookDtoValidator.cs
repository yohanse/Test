using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Cinema.Validators
{
    public class IBookDtoValidator : AbstractValidator<IBookDto>
    {
        public IBookDtoValidator()
        {
            RuleFor(book => book.title)
                .NotEmpty().WithMessage("title is required.")
                .MaximumLength(100).WithMessage("title must not exceed 100 characters.");

            RuleFor(book => book.releaseYear)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .LessThanOrEqualTo(DateTime.Now).WithMessage("{PropertyName} must be less than to current date.");

            RuleFor(book => book.genere)
            .IsInEnum().WithMessage("{PropertyName} is not a valid enum value.");

            RuleFor(book => book.UserId)
            .GreaterThan(0).WithMessage("{PropertyName} must be less greater than 1.");
        }
    }
}
