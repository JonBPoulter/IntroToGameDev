using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPoint : MonoBehaviour {
    public GameObject Point;
    float PenX;
    float PenY;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        PenY = Point.transform.position.y + .5f;
        PenX = Point.transform.position.x;
        transform.position = new Vector3(PenX, PenY, transform.position.z);
        


    }
    void OnCollisonEnter2D(Collider2D Col)
    {
        if (Col.gameObject.tag == "Doodle")
        {
            Destroy(Col.gameObject);
            GameManager.Ink = 0;
        }
        //Ignore();
        if (Col.gameObject.tag == "Ink")
        {
            Destroy(gameObject);
            GameManager.Ink += 100;
        }

    }
}
