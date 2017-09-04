using PoeOverlay.ModelLogic;

namespace PoeOverlay.PureLogic
{
    public interface ICurrencyFinder
    {
        ICurrency ByName(string name);
    }
}