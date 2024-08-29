using Core.Entities;

namespace Entities.Concretes
{
    public class BankBalance:IEntity
    {
        public int Id { get; set; }
        public int BankId { get; set; }
        public int CurrencyId { get; set; }
        public int Balance { get; set; }
    }

}
