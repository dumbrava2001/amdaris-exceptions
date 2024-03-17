using AssignmentExceptions;
using AssignmentExceptions.Exceptions;

internal static class Program
{
    private static void Main(string[] args)
    {
        var euro = new Money(240, "EUR");
        var dollars = new Money(300, "USD");
        var moneyAfterCovid = new Money(0, "EUR");

        try
        {
            //Will produce argument exception
            // var remaining = MoneyOperations.Divide(euro, moneyAfterCovid);
            
            //Will produce invalid currency exception
            var remaining = MoneyOperations.Divide(euro, dollars);
            Console.WriteLine(remaining);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e);
            throw new MoneyOperationException("Provided arguments are invalid...", e);
        }
        catch (InvalidCurrencyOperationException e)
        {
            Console.WriteLine(e);
            throw new MoneyOperationException("Provided currency are different", e);
        }
    }
}