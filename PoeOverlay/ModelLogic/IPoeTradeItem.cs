namespace PoeOverlay.ModelLogic
{
    public interface IPoeTradeItem : IItem
    {
        string Id { get; set; }
        string WikiLink { get; set; }

        string SellerId { get; set; }
        string SellerAccountName { get; set; }
        string StashTab { get; set; }
        int StashX { get; set; }
        int StashY { get; set; }
    }
}