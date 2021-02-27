using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            if (rental.ReturnDate == null)
            {
                return new ErrorResult(Messages.CarNoRent);
            }
            return new SuccessResult(Messages.CarRent);
        }

        public IResult Delete(Rental rental)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Rental>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Rental>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.CarsListed);
        }


        public IDataResult<List<RentalDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetCarDetails());
        }

        public IResult Update(Rental rental)
        {
            throw new NotImplementedException();
        }
    }
}
