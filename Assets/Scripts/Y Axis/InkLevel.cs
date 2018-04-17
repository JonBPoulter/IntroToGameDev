using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InkLevel : MonoBehaviour {
    static public float Xscale;
	public float scaleAdjust = 0.0025f;
    private float Inktotal;
    private float Currentink;
	Vector3 StartPos;
	// Use this for initialization
	void Start () {
		StartPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        Inktotal = GameManager.AmountofInk;
        Currentink = GameManager.Ink;
        Xscale = Currentink / Inktotal;
        transform.localScale = new Vector3(Xscale, transform.localScale.y);
		transform.localPosition = new Vector3 (transform.localPosition.x - scaleAdjust, transform.localPosition.y, transform.localPosition.z); // doesn't work if you get ink tho

		if (Inktotal <= 0) {
			Destroy (this.gameObject);
		}
	}
}
