using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStrategy
{
    public static class ExchangeValues
    {
        public static List<CurrencyExchangeModel> Exchanges { get; set; } = new List<CurrencyExchangeModel>()
        {
            new CurrencyExchangeModel() { Value = 1, Currency = CurrencyEnum.BRL},
            new CurrencyExchangeModel(){ Value = 5.22m, Currency = CurrencyEnum.USD},
            new CurrencyExchangeModel(){ Value = 5.14m, Currency = CurrencyEnum.EUR},
            new CurrencyExchangeModel(){ Value = 0.33m, Currency = CurrencyEnum.ARS},
            new CurrencyExchangeModel(){ Value = 2, Currency = CurrencyEnum.UYU},
            new CurrencyExchangeModel(){ Value = 2, Currency = CurrencyEnum.GBP}
        };

        public static decimal GetValue(CurrencyEnum currency)
        {
            return Exchanges.Where(a => a.Currency == currency).FirstOrDefault().Value;
        }
    }
}
