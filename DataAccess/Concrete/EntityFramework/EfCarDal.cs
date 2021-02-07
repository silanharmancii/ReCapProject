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
    public class EfCarDal : EfEntityRepositoryBase<Car, CarMarketContext>, ICarDal
    {
        public List<CarDetailDto> GetProductDetails()
        {
           using(CarMarketContext context =new CarMarketContext())
            {
                var result = from p in context.Cars
                             join b in context.Brands
                             on p.BrandId equals b.Id
                             join c in context.Colors
                             on p.ColorId equals c.Id
                             select new CarDetailDto
                             {
                                 CarId=p.Id,
                                 CarName = p.CarName,
                                 BrandName = b.BrandName,
                                 ColorName = c.ColorName,
                                 DailyPrice = p.DailyPrice

                             };
                return result.ToList();
            }
        }
    }
}
