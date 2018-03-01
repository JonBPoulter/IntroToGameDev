using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public GameObject[] JustDrawn;
    public GameObject[] Drawn;
    public GameObject Pen;
    public bool Move=false;
    static public float Ink;
    static public bool Drawing=false;
    public GameObject InkLevel;
    private bool Drew = false;
   
 
	// Use this for initialization
	void Start () {
        Ink = 1000;
        
        
		
	}
	
	// Update is called once per frame
	void Update () {
        

        JustDrawn = GameObject.FindGameObjectsWithTag("NotDrawn");
        foreach(GameObject i in JustDrawn)
        {
            i.tag = "Doodle";
        }
        Drawn = GameObject.FindGameObjectsWithTag("Doodle");
        ShrinkInk();

        if (Ink == 0)
        {
            Destroy(Pen);
        }
    
		
	}
    void ShrinkInk()
    {
        Vector3 InkLevel = transform.localScale;
        InkLevel.y = (Ink / 1000);
      
            if (Drawing)
            {
                Ink  = Ink - 1;
            
            Debug.Log("Shrinking");
            Drew = true;
            if (Drew)
            {
                transform.localScale = InkLevel;
            }
            Drew = false;


        }

        }
    
}
