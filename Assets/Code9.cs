using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Code9 : MonoBehaviour
{
    public int x;
    public int y;

    void Start()
    {
        Debug.Log(isDivisor(x, y));
    }
    bool isDivisor(int x, int y)
    {
        return y%x == 0;
    }
}
