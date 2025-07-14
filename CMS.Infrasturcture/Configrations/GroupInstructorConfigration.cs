using CMS.Core.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Infrasturcture.Configrations
{
    public class GroupInstructorConfigration : AbstractValidator<GroupInstructor>
    {
        public GroupInstructorConfigration()
        {
            RuleFor(x => x.GroupId)
           .GreaterThan(0).WithMessage("GroupId must be a valid ID.");

            RuleFor(x => x.InstructorId)
                .GreaterThan(0).WithMessage("InstructorId must be a valid ID.");
        }
    }
}
