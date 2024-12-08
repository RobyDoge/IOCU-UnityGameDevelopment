
using System.IO;
using UnityEngine;

public class PreviousTimeSaver : Saver
{
    [SerializeField]
    private Timer _timer;

    public override void Save()
    {
        string dataPath = $"{Application.persistentDataPath}/{SaveLoadConstants.PREVIOUS_TIMER_FILE_NAME}";
        if (!File.Exists(dataPath))
        {
            File.Create(dataPath).Dispose();
        }

        using FileStream fileStream = new FileStream(dataPath, FileMode.Open);
        using BinaryWriter writer = new BinaryWriter(fileStream);
        TimerDTO timerDTO = _timer.TimerDTO;
        string timerDTOJson = JsonUtility.ToJson(timerDTO);
        writer.Write(timerDTOJson);
    }
}
