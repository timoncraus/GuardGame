using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddleTask3 : MonoBehaviour
{
    //public string inputStr;
    public int[] inputList;
    // Start is called before the first frame update
    void Start()
    {
        //int[] list = System.Array.ConvertAll(inputStr.Split(' '), s => int.Parse(s));
        Debug.Log(EvenSum(inputList));
    }
    int EvenSum(int[] list)
    {
        int sum = 0;
        bool hasAdded = false;
        foreach(int number in list)
        {
            if(number%2 == 0)
            {
                sum += number;
                hasAdded = true;
            }
        }
        if(!hasAdded || list.Length == 0)
        {
            return -1;
        }
        return sum;
    }
}
