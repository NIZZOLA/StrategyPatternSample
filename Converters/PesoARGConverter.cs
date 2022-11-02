using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStrategy.Converters;

internal class PesoARGConverter : ICurrencyConverter
{
    public decimal ConvertFromBrl(decimal value)
    {
        return value / ExchangeConstants.ARS;
    }

    public decimal ConvertToBrl(decimal value)
    {
        return value * ExchangeConstants.ARS;
    }
}
