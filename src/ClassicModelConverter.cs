namespace ConsoleStrategy;

public class ClassicModelConverter
{
    public decimal ConvertFromBrl(decimal value, CurrencyEnum currency)
    {
        switch (currency)
        {
            case CurrencyEnum.BRL:
                return value / ExchangeValues.GetValue(CurrencyEnum.BRL);
            case CurrencyEnum.USD:
                return value / ExchangeValues.GetValue(CurrencyEnum.USD);
            case CurrencyEnum.EUR:
                return value / ExchangeValues.GetValue(CurrencyEnum.EUR);
            case CurrencyEnum.GBP:
                return value / ExchangeValues.GetValue(CurrencyEnum.GBP);
            case CurrencyEnum.ARS:
                return value / ExchangeValues.GetValue(CurrencyEnum.ARS);
            case CurrencyEnum.UYU:
                return value / ExchangeValues.GetValue(CurrencyEnum.UYU);
            default:
                return value;
        }
    }
    public decimal ConvertToBrl(decimal value, CurrencyEnum currency)
    {
        switch (currency)
        {
            case CurrencyEnum.BRL:
                return value * ExchangeValues.GetValue(CurrencyEnum.BRL);
            case CurrencyEnum.USD:
                return value * ExchangeValues.GetValue(CurrencyEnum.USD);
            case CurrencyEnum.EUR:
                return value * ExchangeValues.GetValue(CurrencyEnum.EUR);
            case CurrencyEnum.GBP:
                return value * ExchangeValues.GetValue(CurrencyEnum.GBP);
            case CurrencyEnum.ARS:
                return value * ExchangeValues.GetValue(CurrencyEnum.ARS);
            case CurrencyEnum.UYU:
                return value * ExchangeValues.GetValue(CurrencyEnum.UYU);
            default:
                return value;
        }
    }
}
