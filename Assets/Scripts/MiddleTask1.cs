using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddleTask1 : MonoBehaviour
{
    public string inputStr;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(maxNumberMethod(inputStr));
    }
    int maxNumberMethod(string str)
    {
        string[] list = str.Split(' ');
        int maxNum = int.Parse(list[0]);
        foreach(string number in list)
        {
            if(int.Parse(number) > maxNum)
            {
                maxNum = int.Parse(number);
            }
        }
        return maxNum;

    }
}
