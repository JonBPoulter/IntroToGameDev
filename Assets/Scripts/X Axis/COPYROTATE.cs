using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class COPYROTATE : MonoBehaviour {
    public GameObject Pen;
    public float Angle;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.rotation = Pen.transform.rotation;
		
	}
}
