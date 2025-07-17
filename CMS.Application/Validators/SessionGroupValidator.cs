using CMS.Core.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Application.Validators
{
    public class SessionGroupValidator : AbstractValidator<SessionGroup>
    {
        public SessionGroupValidator() 
        {
            RuleFor(x => x.SessionId)
            .GreaterThan(0).WithMessage("SessionId must be a valid ID.");

            RuleFor(x => x.GroupId)
                .GreaterThan(0).WithMessage("GroupId must be a valid ID.");
        }
    }
}
