using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] private TextMeshProUGUI NumberOfDayDayText;
    [SerializeField] float remainingTime;

    public int NumberOfDay;
    private int DayDurationSec = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        remainingTime += Time.deltaTime;
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{0:00}:{1:00} : Gameplay time", minutes, seconds);

        if (seconds > DayDurationSec && NumberOfDay <= 19)
        {
            NumberOfDay += 1;
            NumberOfDayDayText.text = string.Format("Day: {0}", NumberOfDay);
            Debug.Log($"Day:{NumberOfDay}");
            DayDurationSec += 2;
        }
        else
        {
            NumberOfDayDayText.text = string.Format("Day: {0}", NumberOfDay);
        }
        
    }
}
