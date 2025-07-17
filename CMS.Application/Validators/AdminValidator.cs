using CMS.Core.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Application.Validators
{
    public class AdminValidator : AbstractValidator<Admin>
    {
        public AdminValidator()
        {
            RuleFor(x => x.BirthDate)
                .NotNull().WithMessage("Birth date is required.")
                .LessThan(DateTime.Today.AddYears(-10)).WithMessage("Admin must be at least 10 years old.");

        }
    }
}
