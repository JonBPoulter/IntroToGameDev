using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    GameObject Pen;
    public float offset;

    // Use this for initialization
    void Start()
    {

        Pen = GameObject.Find("Pen");

    }

    // Update is called once per frame
    void Update()
    {

        transform.position = new Vector3(Pen.transform.position.x + offset, transform.position.y, transform.position.z);

    }
}