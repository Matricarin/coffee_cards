namespace CoffeeCards.Domain.Entities.RulesAggregate;

public sealed class PurchaseCountRules : ProgramRules
{
    public int TargetCount { get; set; }
}