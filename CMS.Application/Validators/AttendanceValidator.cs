using CMS.Core.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Application.Validators
{
    public class AttendanceValidator : AbstractValidator<Attendance>
    {
        public AttendanceValidator() 
        {
            RuleFor(x => x.SessionId)
            .NotNull().WithMessage("SessionId is required.");

            RuleFor(x => x.StudentId)
                .NotNull().WithMessage("StudentId is required.");

            RuleFor(x => x.AttendanceStatus)
                .NotEmpty().WithMessage("Status is required.")
                .WithMessage("Status must be either 'Present' or 'Absent'.");

            RuleFor(x => x.Note)
                .MaximumLength(250).WithMessage("Note cannot be more than 250 characters.");
        }
    }
}
