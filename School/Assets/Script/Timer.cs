using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Timer : MonoBehaviour
{
    [HideInInspector]
    public int currentDay = 1;
    [HideInInspector]
    public int currentMonth = 1;
    [HideInInspector]
    public int currentYear = 1949;
    [HideInInspector]
    public string CurrentTime;
    bool timeRunning = true;

    public void StopTime()
    {
        timeRunning = false;
    }
    public void StartTime()
    {
        timeRunning = true;
    }

    [HideInInspector]
    public string currentText = "January 1. 1949";
    float time = 0;
    public TextMeshProUGUI timer;

    public void UpdateTime(float t)
    {
        print(t);
        time += t;
        if (time >= .1)
        {
            currentDay++;
            time = 0;
        }
        if (currentMonth == 2 && currentDay > 28)
        {
            currentDay = 1;
            currentMonth++;
        }
        else if (currentMonth == 4 && currentDay > 30)
        {
            currentDay = 1;
            currentMonth++;
        }
        else if (currentMonth == 6 && currentDay > 30)
        {
            currentDay = 1;
            currentMonth++;
        }
        else if (currentMonth == 9 && currentDay > 30)
        {
            currentDay = 1;
            currentMonth++;
        }
        else if (currentMonth == 11 & currentDay > 30)
        {
            currentDay = 1;
            currentMonth++;
        }
        else if (currentMonth == 12 && currentDay > 31)
        {
            currentDay = 1;
            currentMonth = 1;
            currentYear++;
        }
        else if (currentDay > 31)
        {
            currentDay = 1;
            currentMonth++;
        }
        switch (currentMonth)
        {
            case 1:
                currentText = "January ";
                break;
            case 2:
                currentText = "February ";
                break;
            case 3:
                currentText = "March ";
                break;
            case 4:
                currentText = "April ";
                break;
            case 5:
                currentText = "May ";
                break;
            case 6:
                currentText = "June ";
                break;
            case 7:
                currentText = "July ";
                break;
            case 8:
                currentText = "August ";
                break;
            case 9:
                currentText = "September ";
                break;
            case 10:
                currentText = "October ";
                break;
            case 11:
                currentText = "November ";
                break;
            case 12:
                currentText = "December ";
                break;
        }

        string UwU = currentDay + ". " + currentText + currentYear.ToString();
        CurrentTime = UwU;
        timer.text = UwU;
    }
}
