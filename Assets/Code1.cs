using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Code1 : MonoBehaviour
{
    public float a;
    public float b;
    // Start is called before the first frame update
    void Start()
    {
        float c = Mathf.Sqrt(a * a + b * b);
        Debug.Log(a+b+c);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
