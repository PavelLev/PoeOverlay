using System.Collections.Generic;
using PoeOverlay.Utitlity;

namespace PoeOverlay.ModelLogic
{
    public class ItemWhisperHandler : IItemWhisperHandler
    {
        public Queue<IItem> ItemsToWhisper { get; } = new Queue<IItem>();
        public void Handle(IItemSearch itemSearch, IItem item)
        {
            if (itemSearch.AutoWhisper && !item.Buyout.IsEmpty)
            {
                MyServiceContainer.GetInstance<INotificationSoundPlayer>().Play();
                ItemsToWhisper.Enqueue(item);
            }
        }
    }
}