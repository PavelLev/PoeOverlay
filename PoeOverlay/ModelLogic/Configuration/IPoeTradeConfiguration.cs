using System.Collections.Generic;

namespace PoeOverlay.ModelLogic.Configuration
{
    public interface IPoeTradeConfiguration
    {
        IDictionary<string, int> CurrencyToId { get; }
        IList<string> SeenItemsIds { get; }
    }
}