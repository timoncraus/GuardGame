using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasyTask5 : MonoBehaviour
{
    public int num1;
    public int num2;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(higherNumber(num1, num2).ToString() + " больше");
    }
    int higherNumber(int num1, int num2)
    {
        return (num1 > num2) ? num1 : num2;
    }
}
