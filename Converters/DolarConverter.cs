using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStrategy.Converters;

internal class DolarConverter : ICurrencyConverter
{
    public decimal ConvertFromBrl(decimal value)
    {
        return value / ExchangeConstants.USD;
    }

    public decimal ConvertToBrl(decimal value)
    {
        return value * ExchangeConstants.USD;
    }
}
