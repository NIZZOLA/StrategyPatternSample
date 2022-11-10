namespace ConsoleStrategy;

public class CurrencyConverter
{
    public decimal ToBrl(decimal value, ICurrencyConverter converter)
    {
        return converter.ConvertToBrl(value);
    }

    public decimal FromBrl(decimal value, ICurrencyConverter converter)
    {
        return converter.ConvertFromBrl(value);
    }
}
