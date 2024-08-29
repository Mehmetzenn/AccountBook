using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Safe : IEntity
    {
        public int Id { get; set; }
        public string SafeCode { get; set; }
        public string SafeName { get; set; }
    }
}
