using Business.Abstracts;
using Core.Utilities.Results;
using DataAcces.Abstracts;
using Entities.Concretes;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class SafeManager:ISafeService
    {
        private ISafeDal _safeDal;
        public SafeManager(ISafeDal safeDal)
        {
            _safeDal = safeDal;
        }

        public IResult Add(Safe safe)
        {
            _safeDal.Add(safe);
            return new SuccessResult("Kasa Eklendi");
        }

        public IResult Delete(Safe safe)
        {
            _safeDal.Delete(safe);
            return new SuccessResult();
        }

        public IDataResult<List<Safe>> GetAll()
        {
            return new SuccessDataResult<List<Safe>>(_safeDal.GetAll(),"Tüm kasalar Getirildi");
        }

        public IDataResult<Safe> GetById(int id)
        {   
            return new SuccessDataResult<Safe>(_safeDal.Get(s => s.Id == id), "Kasa id ye Göre Getirildi");
        }

        public IDataResult<List<SafeDto>> GetSafeDetail()
        {
            return new SuccessDataResult<List<SafeDto>>(_safeDal.GetSafeDetail());
        }

        public IDataResult<SafeDto> GetSafeDetailById(int id, int selectedCurrencyId)
        {
            var result = _safeDal.GetSafeDetailById(id,selectedCurrencyId);
            if (result.CurrencyId == 1)
            {
                return new SuccessDataResult<SafeDto>(result);
            }
            else if (result.CurrencyId == 2)
            {
                result.Balance = result.Balance * 0.026m;
                return new SuccessDataResult<SafeDto>(result);
            }
            else if (result.CurrencyId == 3)
            {
                result.Balance = result.Balance * 0.029m;
                return new SuccessDataResult<SafeDto>(result);
            }
            else if (result.CurrencyId == 4)
            {
                result.Balance = result.Balance * 0.022m;
                return new SuccessDataResult<SafeDto>(result);
            }
            else 
            {
                return new ErrorDataResult<SafeDto>();
            }
        }

        public IResult Update(Safe safe)
        {
            _safeDal.Update(safe);
            return new SuccessResult();
        }

    }
}
