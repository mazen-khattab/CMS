using CMS.Core.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Application.Validators
{
    public class StudentValidator : AbstractValidator<Student>
    {
        public StudentValidator()
        {
            RuleFor(x => x.Faculty)
                .NotEmpty().WithMessage("Faculty is required.")
                .MaximumLength(100).WithMessage("Faculty must not exceed 100 characters.");

            RuleFor(x => x.BirthDate)
                .NotNull().WithMessage("Birth date is required.")
                .LessThan(DateTime.Today.AddYears(-10)).WithMessage("Student must be at least 10 years old.");
        }
    }
}
