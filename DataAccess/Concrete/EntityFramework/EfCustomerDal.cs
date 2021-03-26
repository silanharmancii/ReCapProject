using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer,CarMarketContext>,ICustomerDal
    {      
        public List<CustomerDetailDto> GetCustomerDetails()
        {
            using(CarMarketContext context=new CarMarketContext())
            {
                var result = from cu in context.Customers
                             join u in context.Users
                             on cu.UserId equals u.Id
                           
                             select new CustomerDetailDto
                             {
                                 CustomerId=cu.CustomerId,
                                 FirstName=u.FirstName,
                                 LastName=u.LastName,
                                 CompanyName=cu.CompanyName

                             };
                return result.ToList();
            }
        }
    }
}
