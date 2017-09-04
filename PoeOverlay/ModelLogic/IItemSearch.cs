namespace PoeOverlay.ModelLogic
{
    public interface IItemSearch
    {
        string Name { get; set; }

        ISearchEngine SearchEngine { get; set; }

        IPrice MaximumBuyout { get; set; }

        bool AutoWhisper { get; set; }

        bool IgnoreNoBuyout { get; set; }

        void OnItemFound(IItem item);
    }
}