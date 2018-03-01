using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling : MonoBehaviour
{
    public float fallingspeed;
    public static bool Pageturn = false;
    public float pagesturned;


    // Use this for initialization
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, fallingspeed * Time.deltaTime, 0);

        if (Pageturn)
        {
            pagesturned = pagesturned + 1;
            if (pagesturned <= 10)
            {


            fallingspeed = fallingspeed - .75f;
            Pageturn = false;
            Debug.Log(fallingspeed);
            }
            else if (pagesturned > 10 && pagesturned<15)
            {
                fallingspeed = fallingspeed - .5f;
                Debug.Log(fallingspeed);
                Pageturn = false;
            }
            else if (pagesturned > 15)
            {
                fallingspeed = fallingspeed -.1f;
                Debug.Log(fallingspeed);
                Pageturn = false;
            }


        }

        
    }
    void OnTriggerEnter2D(Collider2D Col)
    {
        if (Col.gameObject.tag == "Doodle")
        {
            Destroy(gameObject);
            Debug.Log("Destroyed");
        }
        else if (Col.gameObject.tag == "Ink")
        {
            GameManager.Ink = GameManager.Ink + 50;
        }
    }
    
}
    
