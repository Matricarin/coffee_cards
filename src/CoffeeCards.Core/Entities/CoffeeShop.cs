using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeCards.Core.Entities
{
    public class CoffeeShop
    {
        public Guid Id { get; set; }
        public Guid BrandId{ get; set; }
        public Address Address { get; set; }
    }
}
