using Business.Abstract;
using Business.Constants;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Business.ValidationRules.FluentValidation;

namespace Business.Concrete
{
    public class PaymentManager : IPaymentService
    {
        
        private IPaymentDal _paymentDal;
        private IRentalService _rentalService;
        private ICustomerService _customerService;
        public PaymentManager(IPaymentDal paymentDal, IRentalService rentalService, ICustomerService customerService)
        {
            _paymentDal = paymentDal;
            _rentalService = rentalService;
            _customerService = customerService;
        }
       

        private IResult CheckIfCustomerExists(int customer)
        {
            var result = _customerService.GetCustomerById(customer).Data;
            return result == null ? new ErrorResult(Messages.CarIsNotFound) : (IResult)new SuccessResult();
        }
        private IResult CheckIfRentExists(int rent)
        {
            var result = _rentalService.GetRentalByCarId(rent).Data;
            return result == null ? new ErrorResult(Messages.CarIsNotFound) : (IResult)new SuccessResult();
        }
     

        [ValidationAspect(typeof(PaymentValidator))]
        public IResult Add(Payment entity)
        {
            var result = BusinessRules.Run(CheckIfCustomerExists(entity.CustomerId), CheckIfRentExists(entity.RentalId));
            if (!(result is null)) return result;

            _paymentDal.Add(entity);
            return new SuccessResult(Messages.SuccessAdded);
        }

        public IResult Delete(Payment entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Payment>> GetAll()
        {
            return new SuccessDataResult<List<Payment>>(_paymentDal.GetAll());
        }

        public IDataResult<Payment> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Payment entity)
        {
            throw new NotImplementedException();
        }
    }
}

