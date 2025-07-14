using CMS.Core.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Infrasturcture.Configrations
{
    public class SessionGroupConfigration : AbstractValidator<SessionGroup>
    {
        public SessionGroupConfigration() 
        {
            RuleFor(x => x.SessionId)
            .GreaterThan(0).WithMessage("SessionId must be a valid ID.");

            RuleFor(x => x.GroupId)
                .GreaterThan(0).WithMessage("GroupId must be a valid ID.");
        }
    }
}
