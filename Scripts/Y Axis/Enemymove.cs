using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemymove : MonoBehaviour
{


    float Speedx;
    float Speedy;
    bool DoodleMove;



    // Use this for initialization
    void Start()
    {
        DoodleMove = false;
        Speedx = Random.Range(.5f, 2f);
        Speedy = Random.Range(-1f, 2f);
       // Debug.Log(Speedx + "X" + Speedy + "Y");


    }
    
    // Update is called once per frame
    void Update()
    {
        ChangeDirection();
       
        Vector3 NewPos = new Vector3(transform.position.x + Speedx, transform.position.y + Speedy, transform.position.z);

        if (tag == "Doodle" || tag=="Ink")
        {
            DoodleMove = true;
        }
        if (DoodleMove)
        {
            //Debug.Log("DoodleMove");
            Vector2 Move = Vector2.LerpUnclamped((Vector2)transform.position, (Vector2)NewPos,Time.smoothDeltaTime);
            transform.position = new Vector3(Move.x, Move.y, transform.position.z);

        }

       

    }
    void ChangeDirection()
    {
       
    
     if (transform.position.y >= 6.8f)
        {
            Speedy = Speedy* -1;
        }
        if(transform.position.y<= -6f)
        {
            Speedy = Speedy* -1;
        }
    }
   


}
