using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draw : MonoBehaviour {
   /* public GameObject line;
    public GameObject[] drawnline;
    public float Rx;
    public float Ry;
    Vector3 Ron;
    GameObject Refrence;
    public GameObject TopofPen;
    public GameObject BottomofPen;
    public GameObject PenBody;
    public Ray DrawLine;
  private float TopPenX;
    private float TopPenY;
    private float BotPenX;
    private float BotPenY;
    private float DY;
    private float DX;
    public static bool Rotates;
    public static bool RotatesP;
    public static bool RotatesN;
    public LineRenderer LineDoodle;
    private int LinePoints = 6;
    public Vector3[] LPS = new Vector3[1];
    public Vector3 StartP;
    private Transform Starting;





    // Use this for initialization
    void Start () {
        Refrence = GameObject.Find("PenBody");
        drawnline= GameObject.FindGameObjectsWithTag("DrawnLine");
        Ron = new Vector3(0f, -.15f, 0f);
        LineDoodle.positionCount = LinePoints;
       
        
    }
	
	// Update is called once per frame
	void Update () {
        TopPenX = TopofPen.transform.position.x;
        TopPenY = TopofPen.transform.position.y;
        BotPenX = transform.position.x;
        BotPenY = transform.position.y;
        DX = (TopPenX - transform.position.x);
        DY = TopPenY - transform.position.y;
       Debug.Log(DX + "DX");
       // Vector3 LineDirection = new Vector3(DX+BotPenX,BotPenY-DY, transform.position.z);
        StartP = new Vector3(transform.position.x,transform.position.y,transform.position.z);



        LimitRotate();

        Rx = PenBody.transform.rotation.x;
        Ry = PenBody.transform.rotation.y;
       

        transform.position = Refrence.transform.position;
        if (Input.GetKey("space"))
        {
            DrawDoodle();

            //Debug.Log("draw");
            //Instantiate(line, LPS[i]+Ron, Quaternion.Euler(Rx,Ry, 0));
           


            GameManager.Drawing = true;
        }
        if (Input.GetKeyUp("space"))
        {
            GameManager.Drawing = false;
        }
		
	}

    void DrawCurves()
    {
        //need Top of pen but take the distance and subtract it from bottom of pen 
        //need bottom of pen 
        // Set standard position to move to that is altered based on angle 

    }

    void LimitRotate()
    {
        if (DX < 1.95 || DX > -1.95 && Input.GetKeyDown("Mouse ScrollWheel"));
        {
            Rotates = true;
        }
        if (DX >= 1.7)
        {
            RotatesP = true;
        }
        if (DX <= -1.7)
        {
            RotatesN = true;
        }
    }

   
     void DrawDoodle()
    {
        for(int i=0; i < LinePoints; i++)
        {
            float t = (float)i /(float) LinePoints;
            //LPS[i]= BezPoint(t,StartP,LineDirection);

            LineDoodle.SetPositions(LPS);
            //LineDoodle.GetPosition(i);

            //if (PenBody.transform.position.y - LineDoodle.GetPosition(i).y<=1 && PenBody.transform.position.x - LineDoodle.GetPosition(i).x<1)
            //{
                Instantiate(line, LineDoodle.GetPosition(i) , Quaternion.Euler(Rx, Ry, 0));
            //}

            //Can I create the full line but only have the points active once positions are close enough 


        }
        
        //Instantiate(line, LineDoodle.GetPosition(i) + Ron, Quaternion.Euler(Rx, Ry, 0));


    }
    private Vector3 BezPoint(float t, Vector3 StartP, Vector3 LineDirection)
    {
        LineDirection = new Vector3(DX + BotPenX, DY + BotPenY, transform.position.z);
        return StartP + t * (StartP - LineDirection);
         

    }*/
}
