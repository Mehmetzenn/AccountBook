using Core.DataAccess.EntityFramework;
using DataAcces.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Concretes.EntityFreamwork
{
    public class SafeBalanceDal : EfEntityRepositoryBase<SafeBalance, AccountBookContext>, ISafeBalanceDal
    {
    }
}
