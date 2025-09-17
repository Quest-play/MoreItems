using BepInEx;
using BepInEx.Logging;
using Gatekeeper.Utility;
using GKAPI;
using GKAPI.Achievements;
using GKAPI.Items;
using MoreItems.Content;

namespace MoreItems;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
[BepInDependency(GKAPI.Plugin.PluginGuid)]
public class Plugin : GkPlugin
{
    public const string PluginGuid = "ua.quest_play.moreitems";
    public const string PluginName = "MoreItems";
    private const string PluginVersion = "0.1.0";
    
    internal new static ManualLogSource Log;

    public override void Load()
    {
        base.Load();
        // Plugin startup logic
        Log = base.Log;
        Log.LogInfo($"Plugin {PluginName} is loaded!");
    }

    public override void AddContent()
    {
        if (EventHandler.State != EventHandler.LoadingState.PreInit)
        {
            Log.LogError("Content has to be added during Pre-Init!");
            return;
        }

        GlobalSettings.Instance.buildCheating = true;
        GlobalSettings.Instance.buildDebugConsole = true;
        ItemAPI itemAPI = ItemAPI.Instance;
        AchievementsAPI achievementsAPI = AchievementsAPI.Instance;


        ItemRegisterer itemRegister = new(itemAPI);
        itemRegister.Register();
    }
}
