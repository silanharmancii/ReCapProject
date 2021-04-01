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
        public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
           using(CarMarketContext context =new CarMarketContext())
            {
                var result = from p in filter==null? context.Cars : context.Cars.Where(filter)
                             join b in context.Brands
                             on p.BrandId equals b.Id
                             join c in context.Colors
                             on p.ColorId equals c.Id
                             join i in context.CarImages
                             on p.CarId equals i.CarId
                             select new CarDetailDto
                             {
                                 CarId=p.CarId,
                                 ColorId=c.Id,
                                 BrandId=b.Id,
                                 CarName = p.CarName,
                                 BrandName = b.BrandName,
                                 ColorName = c.ColorName,
                                 DailyPrice = p.DailyPrice,
                                 ModelYear  = p.ModelYear,
                                 ImagePath= i.ImagePath,
                                 Description = p.Description,
                                 Status = !context.Rentals.Any(r => r.CarId == p.CarId && (r.ReturnDate == null || r.ReturnDate > DateTime.Now))
                             };
                return result.ToList();
            }
        }
    }
}
