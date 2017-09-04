using System.Collections.Generic;

namespace PoeOverlay.ModelLogic
{
    public interface IItemWhisperHandler
    {
        Queue<IItem> ItemsToWhisper { get; }
        void Handle(IItemSearch itemSearch, IItem item);
    }
}