using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CreditCardManager : ICreditCardService
    {
        private ICreditCardDal _cardDal;
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

        public IResult Delete(CreditCard card)
        {
            _cardDal.Delete(card);
            return new SuccessResult(Messages.SuccessDeleted);
        }

        public IDataResult<List<CreditCard>> GetAll()
        {
            var data = _cardDal.GetAll();
            return new SuccessDataResult<List<CreditCard>>(data, Messages.SuccessListed);
        }

        public IDataResult<List<CreditCard>> GetByCardNumber(string cardNumber)
        {
            return new SuccessDataResult<List<CreditCard>>(_cardDal.GetAll(p => p.CardNumber == cardNumber));
        }

        public IDataResult<CreditCard> GetById(int id)
        {
            return new SuccessDataResult<CreditCard>(_cardDal.Get(p=>p.Id==id), Messages.SuccessListed);
        }

        public IResult IsCardExist(CreditCard card)
        {
            var result = _cardDal.Get(p => p.NameOnTheCard == card.NameOnTheCard && p.CardNumber == card.CardNumber && p.CardCvv == card.CardCvv);
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
