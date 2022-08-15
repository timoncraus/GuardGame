using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddleTask2 : MonoBehaviour
{
    public int n;
    public int x;
    // Start is called before the first frame update
    void Start()
    {
        string myAnswer = CounterMethod(n, x);
        Debug.Log(myAnswer);
    }
    string CounterMethod(int endNumber, int step)
    {
        int train = 0;
        string answer = "0";
        while (train < endNumber)
        {
            train += step;
            if(train <= endNumber)
            {
                answer += " " + train.ToString();
            }
        }
        return answer;
    }
}
