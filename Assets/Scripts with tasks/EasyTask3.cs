using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasyTask3 : MonoBehaviour
{
    public int weekNumber;
    // Start is called before the first frame update
    enum WeekDay
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    void Start()
    {
        Debug.Log(WhatDayWeek(weekNumber));
    }
    WeekDay WhatDayWeek(int day)
    {
        switch (day)
        {
            case 1:
                return WeekDay.Monday;
            case 2:
                return WeekDay.Tuesday;
            case 3:
                return WeekDay.Wednesday;
            case 4:
                return WeekDay.Thursday;
            case 5:
                return WeekDay.Friday;
            case 6:
                return WeekDay.Saturday;
            case 7:
                return WeekDay.Sunday;
            default:
                throw new System.ArgumentException("Неправильный день недели");
        }
    }
}
