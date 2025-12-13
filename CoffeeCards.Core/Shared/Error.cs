namespace CoffeeCards.Domain.Shared;

public record Error(string Code, string Description, ErrorType Type)
{
    public static Error AccessForbidden(string code, string description)
    {
        return new Error(code, description, ErrorType.AccessForbidden);
    }

    public static Error AccessUnAuthorized(string code, string description)
    {
        return new Error(code, description, ErrorType.AccessUnAuthorized);
    }

    public static Error Conflict(string code, string description)
    {
        return new Error(code, description, ErrorType.Conflict);
    }

    public static Error Failure(string code, string description)
    {
        return new Error(code, description, ErrorType.Failure);
    }

    public static Error NotFound(string code, string description)
    {
        return new Error(code, description, ErrorType.NotFound);
    }

    public static Error Validation(string code, string description)
    {
        return new Error(code, description, ErrorType.Validation);
    }
}