using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AspectRatio : MonoBehaviour {

	// Use this for initialization
	void Start () {
       
            
        float targetaspect = 3.5f / 5.0f; //Desired aspect ratio
        float windowaspect = (float)Screen.width / (float)Screen.height; // determine the game window's current aspect ratio
        float scaleheight = windowaspect / targetaspect;  // current viewport height should be scaled by this amount
        Camera camera = GetComponent<Camera>();  // obtain camera component to modify its viewport

        
        if (scaleheight < 1.0f) // if scaled height is less than current height add filler
        {
                Rect rect = camera.rect;

                rect.width = 1.0f;
                rect.height = scaleheight;
                rect.x = 0;
                rect.y = (1.0f - scaleheight) / 2.0f;

                camera.rect = rect;
            }
            else // add pillarbox
            {
                float scalewidth = 1.0f / scaleheight;

                Rect rect = camera.rect;

                rect.width = scalewidth;
                rect.height = 1.0f;
                rect.x = (1.0f - scalewidth) / 2.0f;
                rect.y = 0;

                camera.rect = rect;
            }


        }
	
	// Update is called once per frame
	void Update () {
		
	}
}
