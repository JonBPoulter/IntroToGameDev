using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public GameObject Pen;
    public bool Move=false;
    static public float Ink;
    static public bool Drawing=true;
    public GameObject InkSize;
    private bool Drew = false;
	public static bool Alive = true;
    static public float AmountofInk=5000;
    public float InkDecrease;
 
	// Use this for initialization
	void Start () {
		
        Ink = AmountofInk;
		
	}
	
	// Update is called once per frame
	void Update () {
        
        
        ShrinkInk();

        if (Ink == 0)
        {
            Destroy(Pen);
            Destroy(InkSize);
            LoadScene();
            
        }
    
		
	}
    void ShrinkInk()
    {
        
      
            if (Drawing)
            {
                Ink  = Ink - InkDecrease;
            
            Debug.Log("Shrinking");
            Drew = true;
            


        }

        }
    private void LoadScene()
    {
       // SceneManager.LoadScene("OutroClip");
    }

	public void RestartGame(){
		SceneManager.LoadScene ("X Axis");
	}
    
}
