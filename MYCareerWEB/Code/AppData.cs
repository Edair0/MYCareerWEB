﻿using IndexedDB.Blazor;
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

        public static void Initialize()
        {

        }

        public static Player CreatePlayer(string fullName, int position, int height)
        {
            return new Player(fullName, position, height);
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

    public class RefreshService
    {
        public event Action RefreshRequested;
        public void CallRequestRefresh()
        {
            RefreshRequested?.Invoke();
        }
    }

}
