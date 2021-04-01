using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class PaymentValidator: AbstractValidator<Payment>
    {
        public PaymentValidator()
        {
            RuleFor(p => p.RentalId).NotEmpty();
            RuleFor(p => p.CustomerId).NotEmpty();
            RuleFor(p => p.TotalPrice).NotEmpty().GreaterThan(0);
        }
    }
}
