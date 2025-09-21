using System.Text.Json.Serialization;

namespace CoffeeCards.Domain.Models
{

    public class Wallet
    {
        [JsonPropertyName("userId")]
        public Guid UserId { get; set; }
        [JsonPropertyName("cardId")]
        public Guid CardId { get; set; }
    }
}
