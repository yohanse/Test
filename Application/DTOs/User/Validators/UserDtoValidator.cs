using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Movie.Validators
{
    public  class UserDtoValidator : AbstractValidator<UserDto>
    {
        public UserDtoValidator() 
        {
            RuleFor(user => user.Name)
                .NotEmpty().WithMessage("Name is required.")
                .MaximumLength(100).WithMessage("Name must not exceed 100 characters.");
        }
    }
}
