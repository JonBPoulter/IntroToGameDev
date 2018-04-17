using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnpaper : MonoBehaviour {
    public GameObject LinedPaper;
    GameObject Pen;
    public GameObject[] Paperclone;
    float Penposy;
    float Sy;
    Vector3 Newpappos;
    Vector3 NewSpawnerpos;
    Vector3 CurrentSpos;
    public float pagecounter;
    public GameObject[] DeadPaper;

    
    

	// Use this for initialization
	void Start () {
        Pen = GameObject.Find("Pen");
        Penposy = Pen.transform.position.y;
        Sy = transform.position.y;
        Newpappos = new Vector3(0, -28, 0);
        NewSpawnerpos = new Vector3(0, -24, 0);
        CurrentSpos = transform.position;
       
        

		
	}

    // Update is called once per frame
    void Update() {
        Paperclone = GameObject.FindGameObjectsWithTag("LivePaper");
        DeadPaper = GameObject.FindGameObjectsWithTag("DeadPaper");
        Penposy = Pen.transform.position.y;
        Sy = transform.position.y;
        if (Penposy - Sy <= 5)
        {
            Debug.Log("Hey");

            transform.position = CurrentSpos + NewSpawnerpos;
            if (Paperclone.Length == 0)
                Instantiate(LinedPaper, transform.position, Quaternion.identity);
            CurrentSpos = CurrentSpos + NewSpawnerpos;
            pagecounter += 1;
            Debug.Log(pagecounter);
            Falling.Pageturn = true;

        }
        foreach (GameObject i in Paperclone)
        {
            i.tag = ("DeadPaper");
        }

    }
}
