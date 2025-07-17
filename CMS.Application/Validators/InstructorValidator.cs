using CMS.Core.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Application.Validators
{
    public class InstructorValidator : AbstractValidator<Instructor>
    {
        public InstructorValidator()
        {
            RuleFor(x => x.Bio)
                .MaximumLength(500).WithMessage("Bio must not exceed 500 characters.");

            RuleFor(x => x.Specialization)
                .MaximumLength(100).WithMessage("Specialization must not exceed 100 characters.");

            RuleFor(x => x.BirthDate)
                .NotNull().WithMessage("Birth date is required.")
                .LessThan(DateTime.Today.AddYears(-10)).WithMessage("Instructor must be at least 10 years old.");
        }
    }
}
