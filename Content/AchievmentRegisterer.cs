using System;
using GKAPI.Achievements;
using GKAPI.Items;

namespace MoreItems.Content;

class AchievmentRegisterer(AchievementsAPI api, GkItem[] items)
{
    private AchievementsAPI achievementsAPI = api;
    private GkItem[] gkItems = items;

    public void Register()
    {
        
    }
}