using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public GameObject TopPP;
    public Vector3 TopPen;
    public Vector3 BottomPen;
    public GameObject BotPen;

    public float TopPenx;
    float BottomPenx;
    float TopPeny;
    float BottomPeny;
    float DesiredPointx;
    float DesiredPointy;

    private void Start()

    {


        TopPen = TopPP.transform.position;
        //Vector3 DistanceTtB = TopPen - BottomPen;
        //Debug.Log(DistanceTtB + "Set Distance");
        BottomPen = BotPen.transform.position;



    }
    [SerializeField] private float rotateSpeed;

    void Update()
    {
        TopPen = TopPP.transform.position;
        BottomPen = BotPen.transform.position;


        BottomPenx = BotPen.transform.position.x;


        TopPeny = TopPP.transform.position.y;
        TopPenx = TopPP.transform.position.x;
        // Debug.Log(TopPenx);
        BottomPeny = BotPen.transform.position.y;

        float Angle = Vector2.Angle(BotPen.transform.position, TopPen);
       // Debug.Log(Angle + "ll");
        transform.Rotate(new Vector3(transform.rotation.x, transform.rotation.y, rotateSpeed * Input.GetAxis("Mouse ScrollWheel")));


        /*
      
        //Debug.Log(TDist+"Dist");

        //Top of Pen position doesn't update 
        float angle = Vector2.Angle(transform.position, TDist);//find the angle between the bottom and top of pen to use in how drawing effects motions
                                                         //Debug.Log(angle);

        Debug.Log(angle+"Angle");*/

        // if (Draw.Rotates)
        //{


        // }
        /* if (Draw.RotatesP)
         {
             transform.Rotate(new Vector3(transform.rotation.x, transform.rotation.y,5));
             Draw.RotatesP = false;
         }
         if (Draw.RotatesN)
         {
             transform.Rotate(new Vector3(transform.rotation.x, transform.rotation.y, -10));
             Draw.RotatesN = false;
         }


     }
     float Angles(Vector2 TopPen, Vector2 Trans)
     {
         Vector2 TDist = (Vector2)TopPen - (Vector2)Trans;
         float sign = (TopPen.x < transform.position.x) ? -1.0f : 1.0f;
         return Vector2.Angle(Vector2.right, TDist) * sign;

     }*/


    }
}

