namespace ConsoleStrategy.Converters;

public class GBPConverter : ICurrencyConverter
{
    public decimal ConvertFromBrl(decimal value)
    {
        return value / ExchangeValues.GetValue(CurrencyEnum.GBP);
    }

    public decimal ConvertToBrl(decimal value)
    {
        return value * ExchangeValues.GetValue(CurrencyEnum.GBP);
    }
}
