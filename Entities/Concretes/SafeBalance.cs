using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class SafeBalance:IEntity
    {
        public int Id { get; set; }
        public int SafeId { get; set; }
        public int CurrencyId { get; set; }
        public decimal Balance { get; set; }
    }
}
