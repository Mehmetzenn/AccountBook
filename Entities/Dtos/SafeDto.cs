using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class SafeDto
    {
        public int Id { get; set; }
        public string SafeCode {  get; set; }
        public string SafeName { get; set; }
        public decimal Balance { get; set; }
        public int? CurrencyId { get; set; }
    }
}
