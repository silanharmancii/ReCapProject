using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CardValidator: AbstractValidator<CreditCard>
    {
        public CardValidator()
        {
            RuleFor(c => c.CardNumber).NotEmpty();
            RuleFor(c => c.CardNumber).Length(16);

            RuleFor(c => c.CardCVV).NotEmpty();
            RuleFor(c => c.CardCVV).Length(3);

            RuleFor(c => c.NameOnTheCard).NotEmpty();
            RuleFor(c => c.TotalMoney).NotEmpty();
        }
       
    }
}
