﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyDoodle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
   
     void OnTriggerEnter2D(Collider2D Col)
    {
        if (Col.gameObject.tag == "Doodle")
        {
            Destroy(Col.gameObject);
        }
    }
}
