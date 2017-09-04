using System.Collections.Generic;
using PoeOverlay.ModelLogic;

namespace PoeOverlay.ModelLogic.Configuration
{
    public interface IItemConfiguration
    {
        IList<IItemSearch> CurrentItemSearches { get; }

        IList<IItemSearch> OldItemSearches { get; }

        IList<IItem> CurrentItems { get; }

        IList<IItem> OldItems { get; }

        IList<string> SeenItemIds { get; }
    }
}