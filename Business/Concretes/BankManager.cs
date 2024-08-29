using Business.Abstracts;
using Core.Utilities.Results;
using DataAcces.Abstracts;
using DataAcces.Concretes.EntityFreamwork;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class BankManager : IBankService
    {
        private IBankDal _bankDal;
        public BankManager(IBankDal bankDal)
        {
            _bankDal = bankDal;
        }
        public IResult Add(Bank bank)
        {
            _bankDal.Add(bank);
            return new SuccessResult();
        }

        public IResult Delete(Bank bank)
        {
            _bankDal.Delete(bank);
            return new SuccessResult();
        }

        public IDataResult<List<Bank>> GetAll()
        {
           return new SuccessDataResult<List<Bank>>(_bankDal.GetAll());
        }

        public IDataResult<Bank> GetById(int id)
        {
            return new SuccessDataResult<Bank>(_bankDal.Get(b => b.Id == id), "Kasa id ye Göre Getirildi");
        }

        public IResult Update(Bank bank)
        {
            _bankDal.Update(bank);
            return new SuccessResult();
        }
    }
}
