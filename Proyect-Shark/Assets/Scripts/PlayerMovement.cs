using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed = 2f;

    [SerializeField] float cameraAxisX;

    [SerializeField] float lifePlayer = 20;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RotateShark();
        //PRESS S
        if (Input.GetKey(KeyCode.S))
        {
            MoveShark(Vector3.right);
        }
        //PRESS W
        if (Input.GetKey(KeyCode.W))
        {
            MoveShark(Vector3.left);
        }
        //PRESS A
        if (Input.GetKey(KeyCode.A))
        {
            MoveShark(Vector3.back);

        }
        //PRESS D
        if (Input.GetKey(KeyCode.D))
        {
            MoveShark(Vector3.forward);

        }
        if (lifePlayer > 0)
        {
            //add 1 unit to z axis to current player (player moves)
            //transform.position += new Vector3 (0,0,1) *speedPlayer;
            lifePlayer = lifePlayer - 0.02f;
            Debug.Log("Me muevo entre la vida y la muerte");

        }
        else
        { //we need to heal with object


            Debug.Log("F");
        }
    }
    private void MoveShark(Vector3 directionShark)
    {
        transform.Translate(speed * Time.deltaTime * directionShark);
    }
    private void RotateShark()
    {
        cameraAxisX += Input.GetAxisRaw("Mouse X");
        Debug.Log(cameraAxisX);
        Quaternion angulo = Quaternion.Euler(0f, cameraAxisX, 0f);
        transform.localRotation = angulo;
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(name + " TRIGGER CON " + other.gameObject.name);
        Destroy(other.gameObject);
        lifePlayer = lifePlayer + 20;

    }

}
