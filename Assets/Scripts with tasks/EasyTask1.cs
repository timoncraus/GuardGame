using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasyTask1 : MonoBehaviour
{
    public float a;
    public float b;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(CalculatePerimetr(a, b));
    }

    float CalculatePerimetr(float a, float b)
    {

        float c = Mathf.Sqrt(a * a + b * b);
        return a + b + c;
    }
}
