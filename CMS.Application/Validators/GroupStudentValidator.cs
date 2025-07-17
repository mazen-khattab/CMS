using CMS.Core.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Application.Validators
{
    public class GroupStudentValidator : AbstractValidator<GroupStudent>
    {
        public GroupStudentValidator()
        {
            RuleFor(x => x.GroupId)
            .GreaterThan(0).WithMessage("GroupId must be a valid ID.");

            RuleFor(x => x.StudentId)
                .GreaterThan(0).WithMessage("StudentId must be a valid ID.");
        }
    }
}
