using System;
using System.Collections.Generic;

namespace CoffeeCards.Core.Entities
{
    public sealed class CoffeeShop
    {
        public Guid Id {get; set;}
        public string Name {get; set;} = string.Empty;  
        public Guid OwnerId {get; set;}
        public ApplicationUser Owner {get; set;} = null!;
        public ICollection<CoffeeShopBranch> Branches {get; set;} = [];
        public ICollection<BonusProgram> BonusPrograms{get; set;} = []; 
    }
}