using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPen : MonoBehaviour {
    GameObject Pen;
    Vector3 Camoffset;
    //Vector3 Penpos;
    

	// Use this for initialization
	void Start () {
        Pen = GameObject.Find("Pen");
        Camoffset = new Vector3(0, -4, 0);
       // Penpos= Pen.transform.position;
        
	}
	
	// Update is called once per frame
	void Update () {

        transform.position = Pen.transform.position +Camoffset;
		
	}
}
