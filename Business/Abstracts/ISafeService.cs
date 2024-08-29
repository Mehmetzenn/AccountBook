using Core.Utilities.Results;
using Entities.Concretes;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ISafeService
    {
        IResult Add(Safe safe);
        IResult Delete(Safe safe);
        IResult Update(Safe safe);
        IDataResult<List<Safe>> GetAll();
        IDataResult<Safe> GetById(int id);
        IDataResult<List<SafeDto>> GetSafeDetail();
        IDataResult<SafeDto> GetSafeDetailById(int id, int selectedCurrencyId);
    }
}
