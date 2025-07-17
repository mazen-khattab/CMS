using CMS.Core.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Application.Validators
{
    public class SessionValidator : AbstractValidator<Session>
    {
        public SessionValidator()
        {
            RuleFor(x => x.Title)
            .NotEmpty().WithMessage("Title is required.")
            .MaximumLength(100).WithMessage("Title must not exceed 100 characters.");

            RuleFor(x => x.Description)
                .MaximumLength(500).WithMessage("Description must not exceed 500 characters.");

            RuleFor(x => x.SessionDate)
                .NotNull().WithMessage("Session date is required.")
                .GreaterThanOrEqualTo(DateTime.Today).WithMessage("Session date cannot be in the past.");

            RuleFor(x => x.StartTime)
                .NotNull().WithMessage("Start time is required.");
        }
    }
}
