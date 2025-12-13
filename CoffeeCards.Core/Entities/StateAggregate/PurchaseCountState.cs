namespace CoffeeCards.Domain.Entities.StateAggregate;

public sealed class PurchaseCountState : ProgramState
{
    public int CurrentCount { get; set; }
}