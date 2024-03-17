using AssignmentExceptions.Exceptions;

namespace AssignmentExceptions;

public class MoneyOperations
{
    public static double Divide(Money initialSum, Money divider)
    {
        if (divider.Amount == 0)
        {
            throw new ArgumentException("Divider amount is 0...");
        }

        if (!string.Equals(initialSum.Currency, divider.Currency, StringComparison.OrdinalIgnoreCase))
        {
            throw new InvalidCurrencyOperationException("Arguments currency types are not equal...");
        }

        return initialSum.Amount / divider.Amount;
    }
}