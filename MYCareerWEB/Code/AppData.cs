using IndexedDB.Blazor;
using Microsoft.AspNetCore.Components;
using MYCareerWEB.Code.PlayerData;
namespace MYCareerWEB.Code
{

    public static class AppData
    {
        public static Player? CurrentPlayer { get; set; }
        public static List<Player> Players { get; set; } = new List<Player>();

        public static void Initialize()
        {

        }

        public static Player CreatePlayer(string firstName, string nickName, string lastName, int position, int height)
        {
            return new Player(firstName, nickName, lastName, position, height);
        }

        public static void AddPlayer(Player player)
        {
            Players.Add(player);
        }

        public static void RemovePlayer(Player player)
        {
            Players.Remove(player);
        }



    }
}
