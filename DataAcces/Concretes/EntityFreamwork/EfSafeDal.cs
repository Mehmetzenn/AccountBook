using Core.DataAccess.EntityFramework;
using DataAcces.Abstracts;
using Entities.Concretes;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Concretes.EntityFreamwork
{
    public class EfSafeDal : EfEntityRepositoryBase<Safe, AccountBookContext>, ISafeDal
    {
        public List<SafeDto> GetSafeDetail()
        {
            using (AccountBookContext context = new AccountBookContext()) 
            {
                var result = from s in context.safes
                             join sb in context.safebalances
                             on s.Id equals sb.Id
                             select new SafeDto { Id = s.Id, Balance = sb.Balance, SafeName = s.SafeName, SafeCode=s.SafeCode };
                return result.ToList();
            }
        }

        public SafeDto GetSafeDetailById(int id,int selectedCurrencyId)
        {
            using (AccountBookContext context = new AccountBookContext())
            {
                var result = (from s in context.safes
                              join sb in context.safebalances
                              on s.Id equals sb.SafeId
                              where s.Id == id
                              select new SafeDto
                              {
                                  Id = s.Id,
                                  SafeName = s.SafeName,
                                  SafeCode = s.SafeCode,
                                  Balance = sb.Balance,
                                  CurrencyId = selectedCurrencyId
                              }).FirstOrDefault();

                return result;
            }
        }

    }
}
