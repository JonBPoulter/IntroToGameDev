using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevisedFollow : MonoBehaviour
{
    public GameObject Pen;
    float cameraypos;
    float speed;
    private GameObject CamSpeed;
    
    void Start()
    {
     

    }

    void Update()

    {
        Vector3 AlteredPenY = new Vector3(Pen.transform.position.x, Pen.transform.position.y - 7, Pen.transform.position.z);
        
        speed = Pen.GetComponent<Falling>().fallingspeed-1;
        //Debug.Log(speed + "CAMFALL");
        Vector2 CamPos= Vector2.Lerp((Vector2)transform.position,(Vector2)AlteredPenY, Time.deltaTime*(speed*-1));
        transform.position = new Vector3(transform.position.x, CamPos.y, transform.position.z);
     
       
        

    }
}
