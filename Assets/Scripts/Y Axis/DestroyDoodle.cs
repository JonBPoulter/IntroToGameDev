using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyDoodle : MonoBehaviour {
    bool ignore;
    Collider2D LineCol;
    private IEnumerator DCOL;

    // Use this for initialization
    void Start () {
        LineCol = GetComponent<Collider2D>();
        DCOL = LoseCollider();
        StartCoroutine(DCOL);
    }
	
	// Update is called once per frame
	void Update () {
        LoseCollider();

    }
   
     void OnCollisonEnter2D(Collider2D Col)
    {
        if (Col.gameObject.tag == "Doodle")
        {
            Destroy(Col.gameObject);
        }
        //Ignore();
        
    }

    void Ignore()
    {
        //Physics2D.IgnoreLayerCollision(2, 3);
    }

    IEnumerator LoseCollider()
    {
        yield return new WaitForSeconds(1.5f);
        if (tag == "Line")
            {
                
                LineCol.enabled = !LineCol.enabled;
                tag = "DrawnLine";
                Debug.Log("COl Removed");


            }
        
       
        }
    
}
