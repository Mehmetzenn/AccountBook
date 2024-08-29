using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class CollectionPayments:IEntity
    {
        public int Id { get; set; }
        public char TransactionC { get; set; }
        public int TransactionNo { get; set; }
        public DateTime TransactionDate { get; set; }
        public int SafeId { get; set; }
        public int BankId { get; set; }
        public string Description { get; set; }
        public char CurrencyC { get; set; }
        public int Ammount { get; set; }
    }
}
