namespace ConsoleStrategy.Converters;

public class USDConverter : ICurrencyConverter
{
    public decimal ConvertFromBrl(decimal value)
    {
        return value / ExchangeValues.GetValue(CurrencyEnum.USD);
    }

    public decimal ConvertToBrl(decimal value)
    {
        return value * ExchangeValues.GetValue(CurrencyEnum.USD);
    }
}
