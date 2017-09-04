using System.Threading.Tasks;
using WebSocketSharp;

namespace PoeOverlay.ModelLogic.SearchEngine
{
    public interface IPoeTradeSearchEngine : ISearchEngine
    {
        string PostUrl { get; set; }
        string WebSocketUrl { get; set; }
        int PostId { get; set; }
        WebSocket WebSocketInstance { get; set; }

        void OnMessage();
        Task<string> GetNewItems(); 
    }
}