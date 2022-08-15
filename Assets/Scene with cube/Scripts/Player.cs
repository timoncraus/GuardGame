using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Camera camera;

    public Transform block;
    Plane plane;
    float hitDist;
    float YPos;
    // Start is called before the first frame update
    void Start()
    {
        plane = new Plane(block.forward, block.position);
        YPos = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);

        if (plane.Raycast(ray, out hitDist))
        {
            var point = ray.GetPoint(hitDist);

            float XPos;
            if(point.x > 9)
            {
                XPos = 9;
            }
            else if(point.x < -11)
            {
                XPos = -11;
            }
            else
            {
                XPos = point.x;
            }

            float ZPos;
            if (point.z > 10.5f)
            {
                ZPos = 10.5f;
            }
            else if (point.z < -2.4f)
            {
                ZPos = -2.4f;
            }
            else
            {
                ZPos = point.z;
            }
            transform.position = new Vector3(XPos, YPos, ZPos);

        }
    }
}
