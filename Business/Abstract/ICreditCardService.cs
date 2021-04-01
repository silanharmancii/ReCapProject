using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICreditCardService 
    {
        IResult Add(CreditCard card);
        IResult Update(CreditCard card);
        IResult Delete(CreditCard card);
        IDataResult<List<CreditCard>> GetAll();
        IDataResult<CreditCard> GetById(int id);
        IResult IsCardExist(CreditCard card);
        IDataResult<List<CreditCard>> GetByCardNumber(string cardNumber);

    }
}
