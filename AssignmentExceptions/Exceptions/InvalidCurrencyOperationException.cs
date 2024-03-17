namespace AssignmentExceptions.Exceptions;

public class InvalidCurrencyOperationException : Exception
{
    public InvalidCurrencyOperationException(string? message) : base(message)
    {
    }

    public InvalidCurrencyOperationException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}