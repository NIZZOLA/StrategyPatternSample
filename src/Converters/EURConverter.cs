namespace ConsoleStrategy.Converters;

public class EURConverter : ICurrencyConverter
{
    public decimal ConvertFromBrl(decimal value)
    {
        return value / ExchangeValues.GetValue(CurrencyEnum.EUR);
    }

    public decimal ConvertToBrl(decimal value)
    {
        return value * ExchangeValues.GetValue(CurrencyEnum.EUR);
    }
}
