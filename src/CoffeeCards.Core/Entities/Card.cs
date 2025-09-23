using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeCards.Core.Entities
{
    public class Card
    {
        public Guid CardId { get; set; }
        public Guid UserId { get; set; }
        public Guid CoffeeShopId { get; set; }
        public required string OfferId{ get; set; }
        public required string PictureUrl { get; set; }
    }
}
