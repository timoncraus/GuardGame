using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform player;
    public Material Material;
    public Transform[] stickList;
    public Transform circle;
    public Transform floor;
    public Transform[] listPlanesTransform;
    public Bonus bonus;
    public float waitingTime = 3;
    Vector3 distance;
    Material myMaterial;

    Material materialFloor;
    float hitDist;
    Plane[] listPlane;
    Ray ray;
    List<Vector3> crossPointList;

    

    float timerEnemy=0;
    int level = 0;
    float speed = 0.6f;
    Vector3 nextTarget;
    int nextRotation;
    bool isDamaged = false;
    
   

    //public LineRenderer line;
    // Start is called before the first frame update
    void Start()
    {
        nextTarget = new Vector3(Random.Range(-11, 9), 7.15f, Random.Range(-2.4f, 10.5f));
        nextRotation = (int)Random.Range(-140, 140);
        if (Mathf.Abs(nextRotation) < 35)
        {
            
            nextRotation += (int) (Random.Range(30, 60) * Mathf.Floor(Random.Range(-1, 1)));
        } 

        myMaterial = gameObject.GetComponent<MeshRenderer>().material;
        materialFloor = floor.GetComponent<MeshRenderer>().material;
        listPlane = new Plane[listPlanesTransform.Length];
        for(int i=0; i< listPlanesTransform.Length; i++)
        {
            var plane = new Plane(listPlanesTransform[i].forward, listPlanesTransform[i].position);
            listPlane[i] = plane;
        }
    }
    void moveTo(Vector3 coords) 
    {
        transform.position = Vector3.Lerp(transform.position, coords, Time.deltaTime * speed);
    }

    void turnOnDegrees(int degrees)
    {
        var newRotation = Quaternion.Euler(transform.rotation.eulerAngles.x, degrees, transform.rotation.eulerAngles.z);
        transform.rotation = Quaternion.Slerp(transform.rotation, newRotation, Time.deltaTime * speed);
    }

    // Update is called once per frame
    void Update()
    {
        if (level == 0)
        {
            if(Vector3.Distance(transform.position, nextTarget) < 1)
            {
                timerEnemy = 0;
                level = 1;
            }
            else
            {
                moveTo(nextTarget);
                turnOnDegrees(nextRotation);
                timerEnemy += Time.time;
            }
        }
        else if (level == 1)
        {
            if (timerEnemy > 1000 * waitingTime)
            {
                timerEnemy = 0;
                level = 0;
                nextTarget = new Vector3(Random.Range(-11, 9), 7.15f, Random.Range(-2.4f, 10.5f));
                nextRotation = (int)Random.Range(-100, 100);
                if (Mathf.Abs(nextRotation) < 35)
                {

                    nextRotation += (int)(Random.Range(30, 60) * Mathf.Floor(Random.Range(-1, 1)));
                }
            }
            else
            {
                timerEnemy += Time.time;
            }
        }



        distance =  player.position - transform.position;
        if(Vector3.Dot(transform.forward, distance.normalized) > 0.7f || Vector3.Distance(transform.position, player.position) < circle.localScale.x / 2)
        {
            gameObject.GetComponent<MeshRenderer>().material = Material;
            floor.GetComponent<MeshRenderer>().material = Material;
            if (!isDamaged)
            {
                bonus.changeText(bonus.count - 10);
            }
            isDamaged = true;
            //дабы единожды отнять 10, а не миллиард раз, пока игрока видит враг всемогущий 
        }
        else
        {
            gameObject.GetComponent<MeshRenderer>().material = myMaterial;
            floor.GetComponent<MeshRenderer>().material = materialFloor;
            isDamaged = false;
        }


        
        foreach(Transform stick in stickList)
        {
            crossPointList = new List<Vector3>();
            int count = 0;
            float modifiedLength = 0;
            Vector3 startBoardPoint = stick.position - stick.forward * stick.localScale.z / 2;
            ray = new Ray(startBoardPoint, stick.forward);
            foreach (Plane plane in listPlane)
            {
                if (plane.Raycast(ray, out hitDist))
                {
                    count += 1;
                    crossPointList.Add(ray.GetPoint(hitDist));
                }
            }
            if (count > 1)
            {
                float min = Vector3.Distance(startBoardPoint, crossPointList[0]);
                foreach (var point in crossPointList)
                {
                    float distanceToPoint = Vector3.Distance(startBoardPoint, point);
                    if (distanceToPoint < min)
                    {
                        min = distanceToPoint;
                    }
                }
                modifiedLength = min;
            }
            stick.position = startBoardPoint + stick.forward * modifiedLength / 2;
            stick.localScale = new Vector3(stick.localScale.x, stick.localScale.y, modifiedLength);
        }
    }
    //private void OnDrawGizmos()
    //{
    //    Gizmos.color = Color.yellow;
    //    foreach (Transform stick in stickList)
    //    {
    //        Gizmos.DrawSphere(stick.position - stick.forward * stick.localScale.z / 2, 0.8f);
    //        Gizmos.DrawRay(stick.position + stick.forward * stick.localScale.z / 2, stick.forward * 10);
    //    }
            
    //    Gizmos.color = Color.blue;
    //    foreach (var point in crossPointList)
    //    {
    //        Gizmos.DrawSphere(point, 0.8f);
    //    }
    //    Gizmos.DrawRay(transform.position, distance.normalized*7);
    //    Gizmos.DrawRay(transform.position, transform.forward*7);
    //}
}
