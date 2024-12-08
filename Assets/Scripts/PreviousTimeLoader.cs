
using System.IO;
using TMPro;
using UnityEngine;

public class PreviousTimeLoader : Loader
{
    [SerializeField]
    private TextMeshProUGUI _PreviousTimeText;


    public override void Load()
    {
        string dataPath = $"{Application.persistentDataPath}/{SaveLoadConstants.PREVIOUS_TIMER_FILE_NAME}";
        if (File.Exists(dataPath))
        {
            using FileStream fileStream = new FileStream(dataPath, FileMode.Open);
            using BinaryReader reader = new BinaryReader(fileStream);

            var timerDTOjson = reader.ReadString();
            TimerDTO timerDTO = JsonUtility.FromJson<TimerDTO>(timerDTOjson);

            string minutesText = timerDTO.minutes < 10 ? $"0{timerDTO.minutes}" : timerDTO.minutes.ToString();
            string secondsText = timerDTO.seconds < 10 ? $"0{timerDTO.seconds}" : timerDTO.seconds.ToString();

            _PreviousTimeText.text += $"{minutesText}:{secondsText}";
        }
        else
        {   _PreviousTimeText.text += "00:00";
        }

    }
}

