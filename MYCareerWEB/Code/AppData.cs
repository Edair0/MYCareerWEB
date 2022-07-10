using IndexedDB.Blazor;
using Microsoft.AspNetCore.Components;
using MYCareerWEB.Code.PlayerData;
namespace MYCareerWEB.Code
{

    public static class AppData
    {
        public static Player CurrentPlayer { get; set; }
        public static List<Player> Players { get; set; } = new List<Player>();
        public static Modifiers Modifiers { get; set; } = new Modifiers();

        public static RefreshService RefreshService = new RefreshService();

        public static Locale Locale = new Locale();

        public static void Initialize()
        {

        }

        public static Player CreatePlayer(string fullName, int position, int height)
        {
            Player player = new Player(fullName, position, height);
            Players.Add(player);
            return player;
        }

        public static void RemovePlayer(Player player)
        {
            Players.Remove(player);
        }

    }

    public class RefreshService
    {
        public event Action RefreshRequested;
        public void CallRequestRefresh()
        {
            RefreshRequested?.Invoke();
        }
    }

}
