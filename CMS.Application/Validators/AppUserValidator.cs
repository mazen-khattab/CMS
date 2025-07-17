using CMS.Core.Entities;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Application.Validators
{
    public class AppUserValidator : AbstractValidator<AppUser>
    {
        public AppUserValidator()
        {
            RuleFor(u => u.FirstName)
            .NotNull().WithMessage("FirstName is required.");

            RuleFor(u => u.LastName)
            .NotNull().WithMessage("LastName is required.");
        }
    }
}
