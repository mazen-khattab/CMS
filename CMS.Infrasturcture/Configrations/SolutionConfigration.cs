using CMS.Core.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Infrasturcture.Configrations
{
    public class SolutionConfigration : AbstractValidator<Solution>
    {
        public SolutionConfigration()
        {
            RuleFor(x => x.TaskId)
            .NotNull().WithMessage("TaskId is required.")
            .GreaterThan(0).WithMessage("TaskId must be a valid ID.");

            RuleFor(x => x.StudentID)
                .NotNull().WithMessage("StudentID is required.")
                .GreaterThan(0).WithMessage("StudentID must be a valid ID.");

            RuleFor(x => x.SubmittedAt)
                .NotEmpty().WithMessage("Submission date is required.")
                .LessThanOrEqualTo(DateTime.Now).WithMessage("Submitted date cannot be in the future.");

            RuleFor(x => x.FileUrl)
                .NotEmpty().WithMessage("File URL is required.")
                .MaximumLength(300).WithMessage("File URL must not exceed 300 characters.");

            RuleFor(x => x.Grade)
                .InclusiveBetween(0, 100)
                .When(x => x.Grade.HasValue)
                .WithMessage("Grade must be between 0 and 100.");
        }
    }
}
