using CMS.Core.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = CMS.Core.Entities.Task;

namespace CMS.Infrasturcture.Configrations
{
    public class TaskConfigration : AbstractValidator<Task>
    {
        public TaskConfigration()
        {
            RuleFor(x => x.Title)
           .NotEmpty().WithMessage("Title is required.")
           .MaximumLength(100).WithMessage("Title must not exceed 100 characters.");

            RuleFor(x => x.Description)
                .MaximumLength(500).WithMessage("Description must not exceed 500 characters.");

            RuleFor(x => x.Deadline)
                .NotNull().WithMessage("Deadline is required.")
                .GreaterThan(DateTime.Now).WithMessage("Deadline must be in the future.");

            RuleFor(x => x.SessionId)
                .GreaterThan(0).WithMessage("SessionId must be a valid ID.");
        }
    }
}
