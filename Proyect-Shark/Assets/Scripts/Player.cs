using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{   public float lifePlayer = 20;
    public string namePlayer = "Pinko";
    public float speedPlayer = 50.0f;
    public Vector3 directionPlayer = new Vector3 (0,0,1) ;
    // Start is called before the first frame update
    void Start()
    {   Debug.Log ("Estoy vivo!");
        transform.position = directionPlayer;
    }

    // Update is called once per frame
    void Update()
    { //if player moves the life goes down
     
        //if player has life then move
       if (lifePlayer > 0)
        {
            //add 1 unit to z axis to current player (player moves)
           transform.position += new Vector3 (0,0,1) *speedPlayer;
           lifePlayer = lifePlayer - 0.02f;
           Debug.Log("Me entre la vida y la muerte :O"); 

        }
       else 
       { //we need to heal with object
           
        
        Debug.Log ("F");
       }

       
       
          if (lifePlayer < 0) 
          {lifePlayer = lifePlayer + 20;}

          


       
        
        
           
       
    }
} 
