using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour {
    public GameObject Pen;
    float speed;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        speed = Pen.transform.position.y;
        transform.position = new Vector3(transform.position.x, Pen.transform.position.y-18, transform.position.z);
     


    }
}
