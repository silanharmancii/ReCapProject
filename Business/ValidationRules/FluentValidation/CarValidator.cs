using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.CarName).NotEmpty();
            RuleFor(c=>c.CarName).MinimumLength(2).WithMessage("Ürün adı en az 2 karakter olmalıdır.");
            RuleFor(c => c.DailyPrice).NotEmpty();
            RuleFor(c => c.DailyPrice).GreaterThanOrEqualTo(0).When(c=>c.BrandId==1);
            //RuleFor(c => c.CarName).Must(StartWithA).WithMessage("Ürünler A arfi ile başlamalı");
        }

       // private bool StartWithA(string arg)
        //{
        //    return arg.StartsWith("A");
       // }
    }
}
