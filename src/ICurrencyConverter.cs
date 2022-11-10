namespace ConsoleStrategy;

public interface ICurrencyConverter
{
    decimal ConvertToBrl(decimal value);
    decimal ConvertFromBrl(decimal value);
}