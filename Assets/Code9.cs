using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Code9 : MonoBehaviour
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
        if(y%x == 0)
        {
            return true;
        }
        return false;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
