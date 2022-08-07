using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Code7 : MonoBehaviour
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
         WhatDayWeek(weekNumber);
    }
    WeekDay WhatDayWeek(int day)
    {
        WeekDay d;
        switch (day) {
            case 1:
                d = WeekDay.Monday;
                break;
            case 2:
                d = WeekDay.Tuesday;
                break;
            case 3:
                d = WeekDay.Wednesday;
                break;
            case 4:
                d = WeekDay.Thursday;
                break;
            case 5:
                d = WeekDay.Friday;
                break;
            case 6:
                d = WeekDay.Saturday;
                break;
            case 7:
                d = WeekDay.Sunday;
                break;
            default:
                return throw new Exception("Wrong day of the week");
               Debug.Log(d.ToString());
                return d;
        }

    }
}
