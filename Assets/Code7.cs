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
        WeekDay day;
        bool gotError = false;
        switch (weekNumber) {
            case 1:
                day = WeekDay.Monday;
                break;
            case 2:
                day = WeekDay.Tuesday;
                break;
            case 3:
                day = WeekDay.Wednesday;
                break;
            case 4:
                day = WeekDay.Thursday;
                break;
            case 5:
                day = WeekDay.Friday;
                break;
            case 6:
                day = WeekDay.Saturday;
                break;
            case 7:
                day = WeekDay.Sunday;
                break;
            default:
                gotError = true;
                day = WeekDay.Monday;
                Debug.Log("������: ������� ����� �� 1 �� 7");
                break;
        }
        if (!gotError)
        {
            Debug.Log(whatDayWeek(day));
        }  
    }
    string whatDayWeek(WeekDay day)
    {
        switch (day) {
            case WeekDay.Monday:
                return "�����������";
            case WeekDay.Tuesday:
                return "�������";
            case WeekDay.Wednesday:
                return "�����";
            case WeekDay.Thursday:
                return "�������";
            case WeekDay.Friday:
                return "�������";
            case WeekDay.Saturday:
                return "�������";
            case WeekDay.Sunday:
                return "�����������";
            default:
                return "";
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
