using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Code1 : MonoBehaviour
{
    void Start()
    {
        Debug.Log(CalculatePerimetr(a, b));
    }
    
    private float CalculatePerimetr(float a, float b)
    {
        float c = Mathf.Sqrt(a * a + b * b);
        return a+b+c;
    }
}
