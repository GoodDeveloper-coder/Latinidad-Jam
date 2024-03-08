using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalendarScript : MonoBehaviour
{
    public GameObject[] CheckMarks;

    public Timer TimerScript;

    private int DaysCompare;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckMarks[TimerScript.NumberOfDay].SetActive(true);
    }
}
