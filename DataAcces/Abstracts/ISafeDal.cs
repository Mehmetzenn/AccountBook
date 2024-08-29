using Core.DataAccess;
using DataAcces.Concretes.EntityFreamwork;
using Entities.Concretes;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Abstracts
{
    public interface ISafeDal : IEntityRepository<Safe>
    {
        List<SafeDto> GetSafeDetail();
        SafeDto GetSafeDetailById(int id, int selectedCurrencyId);
    }
}
