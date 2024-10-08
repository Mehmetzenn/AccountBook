﻿using Core.Utilities.Results;
using DataAcces.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ISafeBalanceService
    {
        IDataResult<SafeBalance> GetById(int id);
        IResult Update(SafeBalance safeBalance);
        IResult Add(SafeBalance safeBalance);
    }
}
