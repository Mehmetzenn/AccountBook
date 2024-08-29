using Core.Utilities.Results;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IBankService
    {
        IResult Add(Bank bank);
        IResult Delete(Bank bank);
        IResult Update(Bank bank);
        IDataResult<List<Bank>> GetAll();
        IDataResult<Bank> GetById(int id);
    }
}
