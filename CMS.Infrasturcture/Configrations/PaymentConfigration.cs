using CMS.Core.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Infrasturcture.Configrations
{
    public class PaymentConfigration : AbstractValidator<Payment>
    {
        public PaymentConfigration()
        {
            RuleFor(x => x.StudentId)
            .NotNull().WithMessage("StudentId is required.");

            RuleFor(x => x.GroupId)
                .NotNull().WithMessage("GroupId is required.");

            RuleFor(x => x.Amount)
                .GreaterThan(0).WithMessage("Amount must be greater than zero.");

            RuleFor(x => x.PaymentDate)
                .NotNull().WithMessage("Payment date is required.")
                .LessThanOrEqualTo(DateTime.Today).WithMessage("Payment date cannot be in the future.");

            RuleFor(x => x.Method)
                .NotEmpty().WithMessage("Payment method is required.")
                .MaximumLength(50).WithMessage("Payment method must not exceed 50 characters.");
        }
    }
}
