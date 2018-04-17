using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopPenUpdatePosition : MonoBehaviour
{
    public GameObject Pen;
    Vector3 TopOnPenPos;
    public GameObject Circle;

    Vector3 ThisPos;
    Vector3 Penpos;
    float Penposy;
    float ThisPosy;
    float Space;

    // Use this for initialization
    void Start()

    {
        Penpos = Pen.transform.position;
        ThisPos = transform.position;
        Penposy = Pen.transform.position.y;
        ThisPosy = transform.position.y;
        Space = Penposy - ThisPosy;

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = ThisPos; 
        

        transform.position = new Vector3(Circle.transform.position.x, Pen.transform.position.y-Space, transform.position.z);


    }
}
