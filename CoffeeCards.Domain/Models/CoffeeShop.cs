using System.ComponentModel.DataAnnotations;

namespace CoffeeCards.Domain.Models
{
    public class CoffeeShop
    {
        public Guid Id { get; set; }
        [Required] public string Name { get; set; } = null!;
    }
}
