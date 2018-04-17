using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InkLevel : MonoBehaviour {
    static public float Xscale;
    private float Inktotal;
    private float Currentink;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Inktotal = GameManager.AmountofInk;
        Currentink = GameManager.Ink;
        Xscale = Currentink / Inktotal;
        transform.localScale = new Vector3(Xscale, transform.localScale.y);
		
	}
}
