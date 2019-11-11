using UnityEngine;

public static class Utils
{

    public static GameResources gameResources;

    public static GameResources InitResources()
    {
        return gameResources = Resources.Load<GameResources>("GameResources");
    }

    public static Sprite GetItemVisualById(int itemId)
    {
        return gameResources.items[itemId];
    }
}