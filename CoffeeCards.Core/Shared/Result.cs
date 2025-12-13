using System.Text.Json.Serialization;

namespace CoffeeCards.Domain.Shared;

public class Result
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Error? Error { get; }

    public bool IsSuccess { get; }

    protected Result()
    {
        IsSuccess = true;
        Error = null;
    }

    protected Result(Error error)
    {
        IsSuccess = false;
        Error = error;
    }

    public static Result Failure(Error error)
    {
        return new Result(error);
    }

    public static implicit operator Result(Error error)
    {
        return new Result(error);
    }

    public static Result Success()
    {
        return new Result();
    }
}