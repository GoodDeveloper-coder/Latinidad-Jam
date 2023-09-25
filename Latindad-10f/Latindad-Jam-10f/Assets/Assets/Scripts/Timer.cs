using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] private TextMeshProUGUI NumberOfDayDayText;
    [SerializeField] float remainingTime;

    private int NumberOfDay;
    private int DayNumber = 600;

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

        if (seconds > DayNumber)
        {
            NumberOfDay += 1;
            NumberOfDayDayText.text = string.Format("Day: {0}", NumberOfDay);
            Debug.Log($"Day:{NumberOfDay}");
            DayNumber += 600;
        }
        
    }
}
