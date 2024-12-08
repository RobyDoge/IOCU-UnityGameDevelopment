
using System.IO;

public class WinSaver : Saver
{
    public override void Save()
    {
        if (!File.Exists(SaveLoadConstants.WIN_COUNT_PATH))
        {
            File.Create(SaveLoadConstants.WIN_COUNT_PATH).Dispose();
        }
        string data = File.ReadAllText(SaveLoadConstants.WIN_COUNT_PATH);
        int.TryParse(data, out int currentWins);
        currentWins++;
        File.WriteAllText(SaveLoadConstants.WIN_COUNT_PATH, currentWins.ToString());

    }
}
