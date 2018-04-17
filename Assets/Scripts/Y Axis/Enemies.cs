using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour {
    public GameObject[] Doodles;
   public GameObject[] DinPlay;
    private IEnumerator Dcour;
    float Spawntime;
    public float Doodlesx;
    public float Doodlesy;
    Vector3 DSLocation;
    bool Timetime=false;
    float Speedx;
    float Speedy;
    Vector3 Move;


    // Use this for initialization
    void Start () {
        Dcour = Dspawn();
        StartCoroutine(Dcour);
        Spawntime = 2f;
		
	}
	
	// Update is called once per frame
	void Update () {
        
        Doodlesy = transform.position.y;
        //DinPlay = GameObject.FindGameObjectsWithTag("NotDrawn");
   
       
            
          /*  foreach (GameObject i in DinPlay)
            {
               transform.position = new Vector3(transform.position.x + 1, transform.position.y + 1, transform.position.z) * Time.deltaTime;
        }
            

    */
        }


       
        

    
    IEnumerator Dspawn()

    {
        while (true)
        {
           // Debug.Log(Spawntime);
           
            yield return new WaitForSeconds(Spawntime);
            Doodlesy = Random.Range(-6.5f, 7f);

            Spawntime = Random.Range(1.5f, 4f);
            Timetime = true;
            //Debug.Log(Spawntime + "AS");
            if (Timetime)
            {
                Speedx = Random.Range(-2f, 2f);
                Speedy = Random.Range(1f, 2.5f);
                DSLocation = new Vector3(transform.position.x, Doodlesy, transform.position.z);
                int i = Random.Range(0, Doodles.Length);
                Instantiate(Doodles[i], DSLocation, Quaternion.identity);
                StartCoroutine(Dcour);
                Timetime = false;
               

            }

        }
    }
  
    }

