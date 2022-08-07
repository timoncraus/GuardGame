using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasyTask2 : MonoBehaviour
{
    public int x;
    public int y;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(isDivisor(x, y));
    }
    bool isDivisor(int x, int y)
    {
        return y % x == 0;
    }
}
