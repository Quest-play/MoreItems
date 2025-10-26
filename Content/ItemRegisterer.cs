using System.Collections.Generic;
using ColorLib;
using static ColorLib.Colors;
using GKAPI.Items;
using Gatekeeper.Items;
using UnityEngine;
using System.IO;

namespace MoreItems.Content;


class ItemRegisterer(ItemAPI api)
{
    private ItemAPI itemAPI = api;
    private List<GkItem> ItemList { get; set; } = [];

    public void Register()
    {
        // Items
        // Clover item
        GkItem cloverItem = itemAPI.AddItem(new GkItem.Builder("CLover", "A mysterious and very rare clover growing in the endless forests of Aurora. It seems to bring luck?", "Increases the chance of items to trigger. \n \n" +
        $" {LibColorHelper.WrapInColor("Riftmaker", Orange)} :" +
        $" {LibColorHelper.WrapInColor("{[Mod1_Lvl1]}% (+{[Mod1_Lvl2]}% per stack)", YellowGreen)} \n" +
        $" {LibColorHelper.WrapInColor("Juju", Orange)} : " +
        $" {LibColorHelper.WrapInColor("{[Mod2_Lvl1]}% (+{[Mod2_Lvl2]}% per stack)", YellowGreen)} \n" +
        $" {LibColorHelper.WrapInColor("Soothe Stone", Orange)} : " +
        $" {LibColorHelper.WrapInColor("{[Mod3_Lvl1]}% (+{[Mod3_Lvl2]}% per stack)", YellowGreen)} \n" +
        $" {LibColorHelper.WrapInColor("Greed's Gambit", Orange)} : " +
        $" {LibColorHelper.WrapInColor("{[Mod4_Lvl1]}% (+{[Mod4_Lvl2]}% per stack)", YellowGreen)} \n" +
        $" {LibColorHelper.WrapInColor("Elix", Orange)} : " +
        $" {LibColorHelper.WrapInColor("{[Mod5_Lvl1]}% (+{[Mod5_Lvl2]}% per stack)", YellowGreen)} \n" +
        $" {LibColorHelper.WrapInColor("Flame Draft", Orange)} : " +
        $" {LibColorHelper.WrapInColor("{[Mod6_Lvl1]}% (+{[Mod6_Lvl2]}% per stack)", YellowGreen)} \n" +
        $" {LibColorHelper.WrapInColor("Bane Seal", Orange)} : " +
        $" {LibColorHelper.WrapInColor("{[Mod7_Lvl1]}% (+{[Mod7_Lvl2]}% per stack)", YellowGreen)} \n" +
        $" {LibColorHelper.WrapInColor("Cursed Shard", Orange)} : " +
        $" {LibColorHelper.WrapInColor("{[Mod8_Lvl1]}% (+{[Mod8_Lvl2]}% per stack)", YellowGreen)} \n" +
        $" {LibColorHelper.WrapInColor("Swarm Pendant", Orange)} : " +
        $" {LibColorHelper.WrapInColor("{[Mod9_Lvl1]}% (+{[Mod9_Lvl2]}% per stack)", YellowGreen)} \n" +
        $" {LibColorHelper.WrapInColor("Inertia", Orange)} : " +
        $" {LibColorHelper.WrapInColor("{[Mod10_Lvl1]}% (+{[Mod10_Lvl2]}% per stack)", YellowGreen)} \n" +
        $" {LibColorHelper.WrapInColor("HVC", Orange)} : " +
        $" {LibColorHelper.WrapInColor("{[Mod11_Lvl1]}% (+{[Mod11_Lvl2]}% per stack)", YellowGreen)} \n" +
        "Growth: Linear")
        .SetHidden(false)
        .SetUnlocked(false)
        .AsRuneOfCreation()
        .WithDropSource(ItemDropSource.Forge | ItemDropSource.Pedestal | ItemDropSource.EndOfRound | ItemDropSource.Obelisks | ItemDropSource.QuitePlaceForge | ItemDropSource.GiftOfArcanum)
        .WithMaxCount(15)
        .WithItemCost(300)
        .WithItemPedestalCost(850)
        .AddModification(ItemParamModificationType.RiftmakerProcChancePerc, 0.02f, 0.02f)
        .AddModification(ItemParamModificationType.JujuReleaseProb, 0.02f, 0.02f)
        .AddModification(ItemParamModificationType.SootheStoneSpawnProb, 0.02f, 0.02f)
        .AddModification(ItemParamModificationType.GreedsGambitItemDropChance, 0.02f, 0.01f)
        .AddModification(ItemParamModificationType.ElixDropChance, 0.05f, 0.02f)
        .AddModification(ItemParamModificationType.FlameDraftDropChance, 0.05f, 0.02f)
        .AddModification(ItemParamModificationType.BaneSealProcChancePerc, 0.05f, 0.02f)
        .AddModification(ItemParamModificationType.CursedShardChancePerc, 0.05f, 0.02f)
        .AddModification(ItemParamModificationType.ResectoidChancePerc, 0.1f, 0.04f)
        .AddModification(ItemParamModificationType.InertiaChancePerc, 0.05f, 0.04f)
        .AddModification(ItemParamModificationType.HvcChancePerc, 0.1f, 0.04f)
        );

        //Scrap
        GkItem scrapModifier = itemAPI.AddItem(new GkItem.Builder("Basic Scrap", "A piece of unknown material. Can be used in a forge to create items.", "Does nothing")
        .SetHidden(false)
        .SetUnlocked(true)
        .AsModifier()
        .WithScrapValue(15)
        .WithDropSource(ItemDropSource.EnemyDeath | ItemDropSource.Pedestal | ItemDropSource.Obelisks | ItemDropSource.EndOfRound)
        );

        GkItem scrapStructure = itemAPI.AddItem(new GkItem.Builder("Better Scrap", "A piece of unknown material. Can be used in a forge to create items.", "Does nothing")
        .SetHidden(false)
        .SetUnlocked(true)
        .AsStructureChanger()
        .WithScrapValue(45)
        .WithDropSource(ItemDropSource.EnemyDeath | ItemDropSource.Pedestal | ItemDropSource.Obelisks | ItemDropSource.EndOfRound)
        );

        ItemList.AddRange([cloverItem]);
    }

    public List<GkItem> getItemList()
    {
        return ItemList;
    }
}