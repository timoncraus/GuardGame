using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Code3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(EvenSum(new int[] {1, 3, 5, 77, 43}));
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
