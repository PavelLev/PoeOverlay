using System.Collections.Generic;
using PoeOverlay.ModelLogic;
using PoeOverlay.ModelLogic.ItemData;

namespace PoeOverlay.ModelLogic
{
    public interface IItem
    {
        string Name { get; set; }

        string SellerCharacterName { get; }
        
        IPrice Buyout { get; set; }
        bool IsBuyoutFixed { get; }

        string Level { get; }
        string RequiredLevel { get; }
        string GemLevel { get; }
        string Quality { get; }
        IList<ISocketLink> SocketLinks { get; }
        IList<IModifier> Modifiers { get; }
        string Whisper { get; }
    }
}