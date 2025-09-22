using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeCards.Core.Entities
{
    public class Brand
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
    }
}
