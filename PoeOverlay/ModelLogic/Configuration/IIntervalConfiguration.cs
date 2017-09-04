namespace PoeOverlay.ModelLogic.Configuration
{
    public interface IIntervalConfiguration
    {
        int Default { get; }

        int Minimum { get; }

        int Value { get; set; }
    }
}