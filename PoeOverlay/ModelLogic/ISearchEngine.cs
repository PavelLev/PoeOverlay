using System;
using Newtonsoft.Json;
using PoeOverlay.Utitlity.JsonConverters;

namespace PoeOverlay.ModelLogic
{
    [JsonConverter(typeof(SearchEngineJsonConverter))]
    public interface ISearchEngine
    {
        // by default search engine is initialized and stopped
        event Action<IItem> ItemFound;
        string Id { get; set; }
        void Initialize();
        void Start();
        void Stop();
    }
}