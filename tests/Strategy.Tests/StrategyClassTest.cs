using ConsoleStrategy;
using ConsoleStrategy.Converters;

namespace Strategy.Tests
{
    public class StrategyClassTest
    {
        public object GetInstance(string strFullyQualifiedName)
        {
            Type type = Type.GetType(strFullyQualifiedName);
            if (type != null)
                return Activator.CreateInstance(type);
            foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
            {
                type = asm.GetType(strFullyQualifiedName);
                if (type != null)
                    return Activator.CreateInstance(type);
            }
            return null;
        }

        [Theory]
        [InlineData(typeof(EURConverter) )]
        [InlineData(typeof(GBPConverter))]
        [InlineData(typeof(PesoARGConverter))]
        [InlineData(typeof(USDConverter))]
        public void ValidateConverter(Type objectType)
        {
            ICurrencyConverter obj = (ICurrencyConverter)this.GetInstance(objectType.AssemblyQualifiedName);
            int baseValue = 10;
            CurrencyConverter converter = new CurrencyConverter();

            var valBrl = converter.ToBrl(baseValue, obj);

            var orignValue = converter.FromBrl(valBrl, obj);

            Assert.Equal(baseValue, orignValue);
        }
    }
}