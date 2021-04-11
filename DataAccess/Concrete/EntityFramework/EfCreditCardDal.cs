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
    public class EfCreditCardDal : EfEntityRepositoryBase<CreditCard, CarMarketContext>, ICreditCardDal
    {
        public List<CardDetailDto> GetCardDetails(Expression<Func<CardDetailDto, bool>> filter = null)
        {
            throw new NotImplementedException();
        }
    }
}
