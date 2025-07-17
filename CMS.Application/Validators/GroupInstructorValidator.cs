using CMS.Core.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Application.Validators
{
    public class GroupInstructorValidator : AbstractValidator<GroupInstructor>
    {
        public GroupInstructorValidator()
        {
            RuleFor(x => x.GroupId)
           .GreaterThan(0).WithMessage("GroupId must be a valid ID.");

            RuleFor(x => x.InstructorId)
                .GreaterThan(0).WithMessage("InstructorId must be a valid ID.");
        }
    }
}
