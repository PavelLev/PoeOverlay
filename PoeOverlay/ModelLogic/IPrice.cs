namespace PoeOverlay.ModelLogic
{
    public interface IPrice
    {
        double Quantity { get; set; }

        string CurrencyShortName { get; set; }

        double ApproximateValue { get; }

        bool IsEmpty { get; }
    }
}