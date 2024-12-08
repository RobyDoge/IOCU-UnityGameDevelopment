using System.IO;
using TMPro;
using UnityEngine;

public class WinLoader :Loader
{
    [SerializeField]
    private TextMeshProUGUI _WinsText;

    public override void Load()
    {
        if (File.Exists(SaveLoadConstants.WIN_COUNT_PATH))
        {
            string data = File.ReadAllText(SaveLoadConstants.WIN_COUNT_PATH);
            int.TryParse(data, out int currentWins);
            _WinsText.text += currentWins.ToString();
        }
        else
        {
            _WinsText.text += "0";
        }
    }
}
