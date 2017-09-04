using System.Collections.Generic;

namespace PoeOverlay.ModelLogic.Configuration
{
    public interface ICurrencyConfiguration
    {
        IList<ICurrency> AllCurrencies { get; }

        IList<string> PriceCurrencies { get; }

        int ApproximateValuePrecision { get; }

        string CurrencyDomain { get; }

        IIntervalConfiguration Interval { get; }
    }
}