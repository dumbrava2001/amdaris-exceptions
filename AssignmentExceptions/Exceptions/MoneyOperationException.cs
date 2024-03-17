namespace AssignmentExceptions.Exceptions;

public class MoneyOperationException : Exception
{
    public MoneyOperationException(string? message) : base(message)
    {
    }

    public MoneyOperationException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}