using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D rigidBody;

    [SerializeField]
    //[Range(0, 100)]
    private float Speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
    }

    // Update is called once per frame
    void Update()
    {
       float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");

        Vector3 oldPosition = transform.position;
        //transform.position = oldPosition + new Vector3(xInput, yInput, 0) * Speed * Time.deltaTime;

        rigidBody.MovePosition(oldPosition + new Vector3(xInput, yInput, 0) * Speed * Time.deltaTime);

    }
}
