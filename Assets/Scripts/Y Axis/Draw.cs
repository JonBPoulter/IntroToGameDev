using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draw : MonoBehaviour {
    public GameObject line;
    public GameObject[] drawnline;
    public float Rx;
    public float Ry;
    Vector3 Ron;
    GameObject Refrence;
    public GameObject TopofPen;
    public GameObject BottomofPen;
    

    // Use this for initialization
    void Start () {
        Refrence = GameObject.Find("PenBody");
        drawnline= GameObject.FindGameObjectsWithTag("DrawnLine");
        Ron = new Vector3(0f, -.1f, 0f);
    }
	
	// Update is called once per frame
	void Update () {
        Rx = transform.rotation.x;
        Ry = transform.rotation.y;

        transform.position = Refrence.transform.position;
        if (Input.GetKey("space"))
        {
            Debug.Log("draw");
            Instantiate(line, transform.position+ Ron, Quaternion.Euler(Rx,Ry, 0));
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
}
