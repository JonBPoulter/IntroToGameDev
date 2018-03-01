using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {
   public Vector3 TopPen;
   public Vector3 BottomPen;
   GameObject TopPP;
    public GameObject BotPen;
    
    float TopPenx;
    float BottomPenx;
    float TopPeny;
    float BottomPeny;
    float DesiredPointx;
    float DesiredPointy;

    private void Start()
    {
        TopPP = GameObject.Find("TopofPen");
        TopPen = TopPP.transform.position;
        BottomPen = BotPen.transform.position;

       
        
    }
    [SerializeField] private float rotateSpeed;

    void Update()
    {
        TopPen = TopPP.transform.position;
        BottomPen = BotPen.transform.position;
        

         BottomPenx = BottomPen.x;
         TopPeny = TopPen.y;
         TopPenx = TopPen.x;
         BottomPeny = BottomPen.y;
        

        Vector3 TDist = (BottomPen-TopPen);
        Debug.Log(TDist+"Dist");

        float angle = Vector3.Angle(TDist, transform.up);//find the angle between the bottom and top of pen to use in how drawing effects motions
        //Debug.Log(angle);

        Debug.Log(angle+"Angle");
        

            transform.Rotate(new Vector3(transform.rotation.x, transform.rotation.y, rotateSpeed * Input.GetAxis("Mouse ScrollWheel")));


        
      
    }

}

