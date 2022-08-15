using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : MonoBehaviour
{
    public string name;
    public int health;
    public int minDamage;
    public int maxDamage;

    public void Introduce()
    {
        Debug.Log("Меня зовут " + name.ToString() + ". Здоровье: " + health.ToString() + "❤️.");
    }

    public void Attack(Warrior w1)
    {
        int d1 = (int)Random.Range(minDamage, maxDamage);
        w1.getHurt(d1);
        Debug.Log(name + " атаковал " + w1.name + ": -" + d1.ToString() + "❤️. " +
            w1.name + ": " + w1.health + "❤️.");
    }

    public void getHurt(int damage)
    {
        health -= damage;
    }
}
