namespace PoeOverlay.ModelLogic.ItemData
{
    public interface IPostResponse
    {
        int Count { get; set; }
        string Data { get; set; }
        int NewId { get; set; }
    }
}