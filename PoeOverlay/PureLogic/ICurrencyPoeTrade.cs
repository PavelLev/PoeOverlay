using System.Collections.Generic;
using System.Windows.Documents;
using PoeOverlay.ModelLogic;

namespace PoeOverlay.PureLogic
{
    public interface ICurrencyPoeTrade
    {
        IList<ICurrencyTradeOffer> GetTradeOffers(ICurrency offered, ICurrency requested);
    }
}