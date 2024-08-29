using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Currency:IEntity
    {
        public int Id { get; set; }
        public string CurrencyC { get; set; }
        public string CurrencyName { get; set; }
    }
}
