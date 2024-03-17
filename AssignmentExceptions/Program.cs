// #define TEST

using AssignmentExceptions;
using AssignmentExceptions.Exceptions;

internal static class Program
{
    private static void Main(string[] args)
    {
        var euro = new Money(240, "EUR");
        var dollars = new Money(300, "USD");
        var moneyAfterCovid = new Money(100, "EUR");

#if (DEBUG)
        moneyAfterCovid.SubtractAmount(100);
#endif

        try
        {
            //Will produce argument exception in TEST mode
            var remaining1 = MoneyOperations.Divide(euro, moneyAfterCovid);
            Console.WriteLine(remaining1);

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
        finally
        {
            Console.WriteLine($"Current account:\nAmount:{euro.Amount}\nCurrency:{euro.Currency}");
        }
    }
}