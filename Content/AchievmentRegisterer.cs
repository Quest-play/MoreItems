using GKAPI.Achievements;
using GKAPI.Items;

namespace MoreItems.Content;

class AchievmentRegisterer(AchievementsAPI api, GkItem[] items)
{
    private AchievementsAPI achievementsAPI = api;
    private GkItem[] gkItems = items;

    public void Register()
    {
        GkAchievement.Builder builder = new();
        builder.Build(10, "Lost artifacts");

        GkAchievement lost_artifacts = achievementsAPI.AddAchievement(builder);
        addItems(lost_artifacts);
    }

    private void addItems(GkAchievement achievement)
    {
        foreach (GkItem item in gkItems)
        {
            achievement.AddItem(item.Info);
        }
    }
}