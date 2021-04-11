using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CreditCardManager : ICreditCardService
    {
        ICreditCardDal _cardDal;
        public CreditCardManager(ICreditCardDal cardDal)
        {
            _cardDal = cardDal;
        }

        [ValidationAspect(typeof(CardValidator))]
        public IResult Add(CreditCard card)
        {
            _cardDal.Add(card);
            return new SuccessResult(Messages.SuccessAdded);
        }

        public IResult AddRental(string cardNumber, Rental rental, decimal amount)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(CreditCard card)
        {
            _cardDal.Delete(card);
            return new SuccessResult(Messages.SuccessDeleted);
        }

        public IDataResult<List<CreditCard>> GetAll()
        {
            return new SuccessDataResult<List<CreditCard>>(_cardDal.GetAll(), Messages.SuccessListed);
        }

        public IDataResult<List<CreditCard>> GetByCardNumber(string cardNumber)
        {
            return new SuccessDataResult<List<CreditCard>>(_cardDal.GetAll(p => p.CardNumber == cardNumber));
        }

        public IDataResult<CreditCard> GetById(int id)
        {
            return new SuccessDataResult<CreditCard>(_cardDal.Get(p=>p.Id==id), Messages.SuccessListed);
        }

        public IDataResult<CardDetailDto> GetCardById(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CardDetailDto>> GetCardByUserId(int userId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CardDetailDto>> GetCardDetails(int id)
        {
            return new SuccessDataResult<List<CardDetailDto>>(_cardDal.GetCardDetails(p => p.CardId == id));
        }

        public IResult IsCardExist(CreditCard card)
        {
            var result = _cardDal.Get(p => p.NameOnTheCard == card.NameOnTheCard && p.CardNumber == card.CardNumber && p.CardCVV == card.CardCVV);
            if (result == null)
            {
                return new ErrorResult();
            }
            return new SuccessResult();
        }

        [ValidationAspect(typeof(CardValidator))]
        public IResult Update(CreditCard card)
        {
            _cardDal.Update(card);
            return new SuccessResult(Messages.SuccessUpdated);
        }
    }
}
