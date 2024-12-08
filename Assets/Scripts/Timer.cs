
using TMPro;
using UnityEngine;

public class Timer: MonoBehaviour
{
    private TextMeshProUGUI _timerText;
    private TimerDTO _timerDTO;
    private string _defaultTimerText;

    public TimerDTO TimerDTO { set; get; }

    private void UpdateTimer()
    {
        if (TimerDTO.seconds < 59)
        {
            TimerDTO.seconds++;
        }
        else
        {
            TimerDTO.seconds = 0;
            TimerDTO.minutes++;
        }
        string minutesText = TimerDTO.minutes < 10 ? "0" + TimerDTO.minutes : TimerDTO.minutes.ToString();
        string secondsText = TimerDTO.seconds < 10 ? "0" + TimerDTO.seconds : TimerDTO.seconds.ToString();
        _timerText.text = $"{_defaultTimerText}{minutesText}:{secondsText}";
    }

    void Start()
    {
        _timerText = GetComponent<TextMeshProUGUI>();
        TimerDTO = new TimerDTO();
        _defaultTimerText = _timerText.text;

        InvokeRepeating("UpdateTimer", 0, 1);
    }

}
