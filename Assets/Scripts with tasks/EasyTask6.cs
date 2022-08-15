using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasyTask6 : MonoBehaviour
{
    public int year;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(convertToCentury(year) + " век");
    }
    int convertToCentury(int year)
    {
        return (int)(year/100)+1;
    }
}
