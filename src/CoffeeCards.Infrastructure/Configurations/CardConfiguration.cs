using CoffeeCards.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoffeeCards.Infrastructure.Configurations
{
    public class CardConfiguration : IEntityTypeConfiguration<Card>
    {
        public void Configure(EntityTypeBuilder<Card> builder)
        {
            builder.ToTable("cards");

            builder.HasKey(c => c.CardId);
            builder.Property(c => c.CardId)
                .HasColumnName("card_id")
                .IsRequired();

            builder.Property(c => c.UserId)
                .HasColumnName("user_id")
                .IsRequired();

            builder.Property(c => c.CoffeeShopId)
                .HasColumnName("coffee_shop_id")
                .IsRequired();

            builder.HasOne(c => c.CoffeeShop)
                .WithMany(s => s.Cards)
                .HasForeignKey(c => c.CoffeeShopId)
                .HasConstraintName("fk_cards_coffeeshop");

            builder.Property(c => c.OfferId)
                .HasColumnName("offer_id")
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(c => c.PictureUrl)
                .HasColumnName("picture_url")
                .HasColumnType("text")
                .IsRequired();

            builder.HasIndex(c => c.UserId).HasDatabaseName("idx_cards_user_id");
            builder.HasIndex(c => c.CoffeeShopId).HasDatabaseName("idx_cards_coffee_shop_id");
        }
    }
}
