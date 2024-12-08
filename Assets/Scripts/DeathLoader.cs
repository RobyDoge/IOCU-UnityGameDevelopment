using TMPro;
using UnityEngine;

public class DeathLoader : Loader
{
    [SerializeField]
    private TextMeshProUGUI _deathText;

    public override void Load()
    {
        int currentDeaths = PlayerPrefs.GetInt(SaveLoadConstants.DEATH_COUNT_KEY);
        _deathText.text += currentDeaths;
    }
}
