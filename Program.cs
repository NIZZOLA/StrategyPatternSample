
// See https://aka.ms/new-console-template for more information
using ConsoleStrategy;
using ConsoleStrategy.Converters;

Console.WriteLine("Hello, World!");

decimal valorOriginal = 1m;

Console.WriteLine("de dólar para R$ = " + new CurrencyConverter().ToBrl(valorOriginal, new DolarConverter()));

Console.WriteLine("de euro para R$ = " + new CurrencyConverter().ToBrl(valorOriginal, new EuroConverter()));

Console.WriteLine("de Peso Arg para R$ = " + new CurrencyConverter().ToBrl(valorOriginal, new PesoARGConverter()));

/*

Console.WriteLine(new DolarConverter().ConvertFromBrl(valorOriginal));
Console.WriteLine(new EuroConverter().ConvertFromBrl(valorOriginal));
Console.WriteLine(new PesoARGConverter().ConvertFromBrl(valorOriginal));
*/
