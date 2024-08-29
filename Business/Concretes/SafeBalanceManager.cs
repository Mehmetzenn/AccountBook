using Business.Abstracts;
using Core.Utilities.Results;
using DataAcces.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class SafeBalanceManager : ISafeBalanceService
    {
        private ISafeBalanceDal _safeBalanceDal;
        public SafeBalanceManager(ISafeBalanceDal safeBalanceDal)
        {
            _safeBalanceDal = safeBalanceDal;
        }

        public IResult Add(SafeBalance safeBalance)
        {
            _safeBalanceDal.Add(safeBalance);
            return new SuccessResult();
        }

        public IDataResult<SafeBalance> GetById(int id)
        {
            return new SuccessDataResult<SafeBalance>(_safeBalanceDal.Get(sb=>sb.Id==id));
        }

        public IResult Update(SafeBalance safeBalance)
        {
            _safeBalanceDal.Update(safeBalance);
            return new SuccessResult();
        }
    }
}
