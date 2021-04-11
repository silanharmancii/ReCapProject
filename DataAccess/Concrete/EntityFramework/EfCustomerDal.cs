using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer,CarMarketContext>,ICustomerDal
    {      
        public List<CustomerDetailDto> GetCustomerDetails(Expression<Func<CustomerDetailDto, bool>> filter = null)
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
                                 CompanyName=cu.CompanyName,
                                 Password=u.PasswordHash,
                                 Email = u.Email,


                             };
                return (filter == null ? result.ToList() :
                                    result.Where(filter).ToList());
            }
        }
       
        public CustomerDetailDto GetCustomerDetailsById(Expression<Func<CustomerDetailDto, bool>> filter)
        {
            using (CarMarketContext context = new CarMarketContext())
            {
                
                var data = from c in context.Customers
                           join u in context.Users on c.UserId equals u.Id
                           select new CustomerDetailDto
                           {
                               CustomerId = c.CustomerId,
                               FirstName = u.FirstName,
                               LastName = u.LastName,
                               Email = u.Email,
                               Password = u.PasswordHash,
                               CompanyName = c.CompanyName
                           };
                

                return data.FirstOrDefault(filter);
            }
        }
    }
}
