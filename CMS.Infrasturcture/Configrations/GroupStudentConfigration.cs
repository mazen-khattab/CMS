using CMS.Core.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Infrasturcture.Configrations
{
    public class GroupStudentConfigration : AbstractValidator<GroupStudent>
    {
        public GroupStudentConfigration()
        {
            RuleFor(x => x.GroupId)
            .GreaterThan(0).WithMessage("GroupId must be a valid ID.");

            RuleFor(x => x.StudentId)
                .GreaterThan(0).WithMessage("StudentId must be a valid ID.");
        }
    }
}
