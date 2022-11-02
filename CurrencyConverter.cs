using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStrategy;

public class CurrencyConverter
{
    public decimal ToBrl(decimal value, ICurrencyConverter converter)
    {
        return converter.ConvertToBrl(value);
    }
}
