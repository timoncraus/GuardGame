using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasyTask4 : MonoBehaviour
{
    public float kilos1;
    public float pounds1; 
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(toPounds(kilos1).ToString() + " фунтов");
        Debug.Log(toKilos(pounds1).ToString() + " килограмм");
    }
    float toPounds(float kilos)
    {
        return kilos * 1000 / 453;
    }
    float toKilos(float pounds)
    {
        return pounds*453/1000;
    }
}
