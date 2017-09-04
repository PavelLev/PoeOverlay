using System.Collections.Generic;
using PoeOverlay.ModelLogic.Configuration;

namespace PoeOverlay.ModelLogic
{
    public interface IConfiguration
    {
        void Load();
        void Save();


        bool ShowOnOffer { get; set; }
        
        string LeagueName { get; set; }

        List<string> TargetTitles { get; }

        int TextBoxDelay { get; }

        ICurrencyConfiguration CurrencyConfiguration { get; }

        IItemConfiguration ItemConfiguration { get; }
    }
}