using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour


{
    public bool isBigger;
    public Vector3 bigger = new Vector3(2f, 2f, 2f);
    public Vector3 little = new Vector3(1f, 1f, 1f);
    public float timelapse = 5f;
    public float time = 5f;
    private int seconds;
    public GameObject prefab;
    void Start()
    {




    }

    private void Update()

    {
      
    }

    private void OnCollisionStay(Collision other)
    {
        Debug.Log(name + " COLISION CON " + other.gameObject.name);
        transform.position += new Vector3();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (isBigger == false)
        {
            transform.localScale = bigger;
        }
        else
        {
            transform.localScale = little;
        }
        isBigger = !isBigger;

    }
    // Start is called before the first frame update

    void ReiniciarTemporizador() { timelapse = time; }
    int Temporizador()
    {
        timelapse -= Time.deltaTime;

        seconds = (int)(timelapse % 60);


        return seconds;
    }
}

