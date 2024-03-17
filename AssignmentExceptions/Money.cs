namespace AssignmentExceptions;

public class Money
{
    public double Amount { get; private set; }
    public string Currency { get; private set; }

    public Money(double amount, string currency)
    {
        Amount = amount;
        Currency = currency;
    }

    public void SubtractAmount(double amount)
    {
        Amount -= amount;
    }
}