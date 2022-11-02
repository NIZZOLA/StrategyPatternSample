using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStrategy;

public interface ICurrencyConverter
{
    decimal ConvertToBrl(decimal value);
    decimal ConvertFromBrl(decimal value);
}