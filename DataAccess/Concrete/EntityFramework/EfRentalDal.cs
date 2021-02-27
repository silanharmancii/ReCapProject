using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarMarketContext>, IRentalDal
    {
        public List<RentalDetailDto> GetCarDetails()
        {
            using (CarMarketContext context = new CarMarketContext())
            {
                var result = from c in context.Cars
                             join r in context.Rentals
                             on c.Id equals r.CarId
                             join cu in context.Customers
                             on r.CustomerId equals cu.CustomerId
                             join u in context.Users
                             on cu.UserId equals u.Id
                             select new RentalDetailDto
                             {
                                RentalId=r.Id,
                                CarName=c.CarName,
                                CustomerName=u.FirstName,
                                RentDate=r.RentDate,
                                ReturnDate=r.ReturnDate
                             };
                return result.ToList();

            }
        }
    }
}
