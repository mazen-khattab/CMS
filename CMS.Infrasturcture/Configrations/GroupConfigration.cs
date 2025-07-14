using CMS.Core.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Infrasturcture.Configrations
{
    public class GroupConfigration : AbstractValidator<Group>
    {
        public GroupConfigration()
        {
            RuleFor(x => x.GroupName)
          .NotEmpty().WithMessage("Group name is required.")
          .MaximumLength(100).WithMessage("Group name must not exceed 100 characters.");

            RuleFor(x => x.StartDate)
                .NotNull().WithMessage("Start date is required.");

            RuleFor(x => x.EndDate)
                .NotNull().WithMessage("End date is required.")
                .GreaterThan(x => x.StartDate.GetValueOrDefault())
                .WithMessage("End date must be after start date.");

            RuleFor(x => x.CourseId)
                .NotNull().WithMessage("CourseId is required.")
                .GreaterThan(0).WithMessage("CourseId must be a valid ID.");
        }
    }
}
