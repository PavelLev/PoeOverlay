namespace PoeOverlay.ModelLogic.ItemData
{
    public interface IModifier
    {
        string Value { get; set; }
        string ShortTier { get; set; }
        string FullTier { get; set; }
    }
}