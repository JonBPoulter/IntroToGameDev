using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinMovement : MonoBehaviour {

        public float MoveSpeed = 5.0f;
        public float frequency = 20.0f;  // Speed of sine movement
        public float magnitude = 0.5f;   // Size of sine movement
        public float magInc = 1f;
        public float frequencyinc=.25f;
        private Vector3 axis;
        public float currentPos;
        public Color[] colors;
        public int currentColor;
        TrailRenderer trail;
        private bool Drawing;
        public float Trailwidth;

        private Vector3 pos;

        // Use this for initialization
        void Start()
        {

            pos = transform.position;
            axis = transform.right;
            trail = GetComponent<TrailRenderer>();
            currentColor = 0;
            trail.startColor = colors[currentColor];
            Trailwidth = .25f;
        StartCoroutine(TrailW());

        }

        // Update is called once per frame
        void Update()
        {
        GameManager.Drawing = true;
         pos += transform.up * Time.deltaTime * MoveSpeed;
         float sin = Mathf.Sin(Time.time * frequency) * magnitude;
         transform.position = pos + axis * Mathf.Sin(Time.time * frequency) * magnitude;
         currentPos = sin;
        trail.startColor = colors[currentColor];
        
        

        if  (Input.GetAxis("Mouse ScrollWheel")>0)
            {

                magnitude += magInc;


            }

            if (Input.GetAxis("Mouse ScrollWheel")<0)
            {

                magnitude -= magInc;

            }

        if (Input.GetKeyDown(KeyCode.A))
        {
            frequency -= frequencyinc;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            frequency += frequencyinc ;
        }
        if (Input.GetMouseButtonDown(0))
            {

                if (currentColor == colors.Length - 1)
                {
                    currentColor = 0;
                    trail.startColor = colors[currentColor];
                }
                else
                {
                    currentColor++;
                    trail.startColor = colors[currentColor];
                }

            }

            if (Input.GetMouseButtonDown(1))
            {

                if (currentColor == 0)
                {
                    currentColor = colors.Length - 1;
                    trail.startColor = colors[currentColor];
                }
                else
                {
                    currentColor--;
                    trail.startColor = colors[currentColor];
                }
            }
        }
    private IEnumerator TrailW()
    {
        yield return new WaitForSeconds(3);
        Trailwidth = (((Trailwidth * InkLevel.Xscale) / Trailwidth) * Trailwidth);
        trail.widthMultiplier = Trailwidth;

    }
    }
