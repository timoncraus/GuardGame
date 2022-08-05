using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Code4 : MonoBehaviour
{
    public string riddle;
    // Start is called before the first frame update
    void Start()
    {
        riddle = "2Boo1Aoo";
        Debug.Log(Decode(riddle));
    }
    string Decode(string riddle)
    {
        var dict = new Dictionary<int, string>();
        int paramNum;
        string paramWord;
        riddle = cutsOffAPart(riddle, out paramNum, out paramWord);
        dict.Add(paramNum, paramWord);

        riddle = cutsOffAPart(riddle, out paramNum, out paramWord);
        dict.Add(paramNum, paramWord);
        foreach(var entry in dict)
        {
            Debug.Log(entry.Key.ToString() + " " + entry.Value.ToString());
        }

        return "";
    }
    string cutsOffAPart(string riddle, out int myNumber, out string myWord)
    {
        int endNumIndex = 1;
        while (isNumber(riddle.Substring(0, endNumIndex)))
        {
            endNumIndex += 1;
        }
        endNumIndex -= 1;

        int endWordIndex = endNumIndex;
        try
        {
            while (!isNumber(riddle[endWordIndex].ToString()))
            {
                endWordIndex += 1;
            }
            endWordIndex -= 1;
        }
        catch
        {
            endWordIndex = riddle.Length - endNumIndex;
        }
        

        myNumber = int.Parse(riddle.Substring(0, endNumIndex));
        myWord = riddle.Substring(endNumIndex, endWordIndex);
        return riddle.Substring(endNumIndex + endWordIndex, riddle.Length - endNumIndex - endWordIndex);

    }
    bool isNumber(string st)
    {
        int stNum;
        try
        {
            stNum = int.Parse(st);
            return true;
        }
        catch
        {
            return false;
        }
    }

}
