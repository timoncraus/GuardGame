using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bonus : MonoBehaviour
{
    public Transform player;
    public Text myText;
    public int count;
    float YPos;
    
    // Start is called before the first frame update
    void Start()
    {
        YPos = transform.position.y;
        transform.position = new Vector3(Random.Range(-11, 9), YPos, Random.Range(-2.4f, 10.5f));
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, player.position) < 1)
        {
            transform.position = new Vector3(Random.Range(-11, 9), YPos, Random.Range(-2.4f, 10.5f));
            count += 1;
            myText.text = count.ToString();
        }
    }
    public void changeText(int number)
    {
        count = number;
        if(count < 0)
        {
            count = 0;
        }
        myText.text = count.ToString();
    }
}
