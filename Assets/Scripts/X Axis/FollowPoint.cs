using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPoint : MonoBehaviour {
    public GameObject Point;
	bool Alive;
    float PenX;
    float PenY;

	// Use this for initialization
	void Start () {
		Alive = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (GameManager.Alive) {
			PenY = Point.transform.position.y + .5f;
			PenX = Point.transform.position.x;
			transform.position = new Vector3 (PenX, PenY, transform.position.z);
		}
		if (GameManager.Ink <= 0) {
			//Alive = false;
			GameManager.Alive = false;
			Debug.Log ("Alive: " + GameManager.Alive + GameManager.Ink);
			Destroy (this.gameObject);
		}

    }
    void OnCollisonEnter2D(Collider2D Col)
    {
        if (Col.gameObject.tag == "Doodle")
        {
            
        }
        //Ignore();
        if (Col.gameObject.tag == "Ink")
        {
            Destroy(gameObject);
            GameManager.Ink += 100;
        }

    }
}
