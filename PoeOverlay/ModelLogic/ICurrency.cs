namespace PoeOverlay.ModelLogic
{
    public interface ICurrency
    {
        string Name { get; }
        double ApproximateValue { get; set; }
    }
}