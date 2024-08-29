using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class TransactionType : IEntity
    {
        public int Id { get; set; }
        public char TransectionC { get; set; }
        public string TransactionName { get; set; }
    }
}
    