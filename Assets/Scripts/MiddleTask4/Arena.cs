using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arena : MonoBehaviour
{
    public Warrior opponent1;
    public Warrior opponent2;
    // Start is called before the first frame update
    void Start()
    {
        startBattle();
    }
    public void startBattle()
    {
        int order = (int)Random.Range(0, 1);
        opponent1.Introduce();
        opponent2.Introduce();
        while (opponent1.health > 0 & opponent2.health > 0)
        {
            if(order == 0)
            {
                opponent1.Attack(opponent2);
                order = 1;
            }
            else if(order == 1)
            {
                opponent2.Attack(opponent1);
                order = 0;
            }
        }
        string winner = "";
        if(opponent1.health > 0)
        {
            winner = opponent1.name;
        }
        if(opponent2.health > 0)
        {
            winner = opponent2.name;
        }
        Debug.Log("Победил " + winner);
    }
}
