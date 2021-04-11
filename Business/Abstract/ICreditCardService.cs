using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICreditCardService 
    {
        IResult AddRental(string cardNumber, Rental rental, decimal amount);
        IResult Add(CreditCard card);
        IResult Update(CreditCard card);
        IResult Delete(CreditCard card);
        IDataResult<List<CreditCard>> GetAll();
        IDataResult<CreditCard> GetById(int id);
        IResult IsCardExist(CreditCard card);    
        IDataResult<List<CreditCard>> GetByCardNumber(string cardNumber);
        IDataResult<List<CardDetailDto>> GetCardByUserId(int userId);
        IDataResult<List<CardDetailDto>> GetCardDetails(int id);
        IDataResult<CardDetailDto> GetCardById(int id);

    }
}
