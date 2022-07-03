using IndexedDB.Blazor;
using Microsoft.AspNetCore.Components;



namespace MYCareerWEB.Code
{

    public static class AppData
    {
        public static int CurrentPlayer { get; set; }
        public static List<Player> Players { get; set; }

        public static void Initialize()
        {
            CurrentPlayer = -1;
            Players = new List<Player>();
        }

        public static Player AddPlayer(string firstName, string nickName, string lastName, int position, int height)
        {
            Player result = new Player(firstName, nickName, lastName, position, height);
            Players.Add(result);
            return result;
        }



    }
}
