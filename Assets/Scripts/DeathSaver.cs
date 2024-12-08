using UnityEngine;

public class DeathSaver : Saver
{
    public override void Save()
    {
        int currentDeaths = PlayerPrefs.GetInt(SaveLoadConstants.DEATH_COUNT_KEY);
        currentDeaths++;
        PlayerPrefs.SetInt(SaveLoadConstants.DEATH_COUNT_KEY, currentDeaths);
    }
}
