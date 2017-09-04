using System.Collections.Generic;
using System.Threading.Tasks;
using AngleSharp.Dom;
using PoeOverlay.ModelLogic;
using PoeOverlay.ModelLogic.ItemData;

namespace PoeOverlay.PureLogic
{
    public interface IPoeTradeHtmlParser
    {
        Task<IList<IItem>> ParseItemsAsync(string input);
        Task<IItem> ParseItemAsync(IElement itemNode);

        string ParseItemName(IElement itemNode);
        string ParseItemSellerCharacaterName(IElement itemNode);
        IPrice ParseItemBuyout(IElement itemNode);
        bool ParseItemIsBuyoutFixed(IElement itemNode);
        string ParseItemLevel(IElement itemNode);
        string ParseItemRequiredLevel(IElement itemNode);
        string ParseItemGemLevel(IElement itemNode);
        string ParseItemQuality(IElement itemNode);
        IList<ISocketLink> ParseItemSocketLinks(IElement itemNode);
        IList<IModifier> ParseItemModifiers(IElement itemNode);
        string ParseItemWhisper(IElement itemNode);

        string ParseItemId(IElement itemNode);
        string ParseItemWikiLink(IElement itemNode);
        string ParseItemSellerId(IElement itemNode);
        string ParseItemSellerAccountName(IElement itemNode);
        string ParseItemStashTab(IElement itemNode);
        int ParseItemStashX(IElement itemNode);
        int ParseItemStashY(IElement itemNode);
    }
}