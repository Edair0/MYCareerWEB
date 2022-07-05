using IndexedDB.Blazor;
using Microsoft.JSInterop;
using MYCareerWEB.Code.PlayerData;
using System;

namespace MYCareerWEB.Code
{
    public class AppDB : IndexedDb
    {
        public AppDB(IJSRuntime jSRuntime, string name, int version) : base(jSRuntime, name, version) { }
        public IndexedSet<Player> Player { get; set; }
    }
}
