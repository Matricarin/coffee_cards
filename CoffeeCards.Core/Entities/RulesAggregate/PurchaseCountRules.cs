namespace CoffeeCards.Core.Entities.RulesAggregate;

public sealed class PurchaseCountRules : ProgramRules
{
    public int TargetCount { get; set; }
}