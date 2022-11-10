namespace ConsoleStrategy.Converters;

public class PesoARGConverter : ICurrencyConverter
{
    public decimal ConvertFromBrl(decimal value)
    {
        return value / ExchangeValues.GetValue(CurrencyEnum.ARS);
    }

    public decimal ConvertToBrl(decimal value)
    {
        return value * ExchangeValues.GetValue(CurrencyEnum.ARS);
    }
}
