using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class Code4 : MonoBehaviour
{
    public string riddle;
    // Start is called before the first frame update
    void Start()
    { 
        Debug.Log(Decode(riddle));
    }
    string Decode(string riddle)
    {
        var dict = new Dictionary<int, string>();
        int paramNum;
        string paramWord;
        while(riddle.Length > 0)
        {
            riddle = cutsOffAPart(riddle, out paramNum, out paramWord);
            dict.Add(paramNum, paramWord);
        }
        //foreach(var entry in dict)
        //{
        //    Debug.Log(entry.Key.ToString() + " " + entry.Value.ToString());
        //}

        int[] listKeys = new int[dict.Keys.Count];
        int i = 0;
        foreach(int key in dict.Keys)
        {
            listKeys[i] = key;
            i += 1;
        }
        var sortedListKeys = listKeys.OrderBy(n => n);
        string answer = "";
        bool first = true;
        foreach(int key in sortedListKeys)
        {
            if (!first) {
                answer += " ";
            }
            answer += dict[key];
            first = false;
        }

        return answer;
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
