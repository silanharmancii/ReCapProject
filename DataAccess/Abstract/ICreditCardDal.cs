using Core.DataAccess;
using Entities.Concrete;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICreditCardDal:IEntityRepository<CreditCard>
    {
        List<CardDetailDto> GetCardDetails(Expression<Func<CardDetailDto, bool>> filter = null);

    }
}
