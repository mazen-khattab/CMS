using CMS.Core.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Infrasturcture.Configrations
{
    public class StudentConfigration : AbstractValidator<Student>
    {
        public StudentConfigration()
        {
            RuleFor(x => x.FullName)
            .NotEmpty().WithMessage("Full name is required.")
            .MaximumLength(100).WithMessage("Full name must not exceed 100 characters.");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email is required.")
                .EmailAddress().WithMessage("Invalid email format.");

            RuleFor(x => x.Phone)
                .NotEmpty().WithMessage("Phone number is required.")
                .Matches(@"^01\d{9}$").WithMessage("Phone must start with 01 and be exactly 11 digits.");

            RuleFor(x => x.PasswordHash)
                .NotEmpty().WithMessage("Password is required.")
                .MinimumLength(6).WithMessage("Password must be at least 6 characters.");

            RuleFor(x => x.Faculty)
                .NotEmpty().WithMessage("Faculty is required.")
                .MaximumLength(100).WithMessage("Faculty must not exceed 100 characters.");

            RuleFor(x => x.BirthDate)
                .NotNull().WithMessage("Birth date is required.")
                .LessThan(DateTime.Today.AddYears(-10)).WithMessage("Student must be at least 10 years old.");

        }
    }
}
