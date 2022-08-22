using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    //Boundary variable
    public float rightBoundary = 15;
    public float leftBoundary = -15;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < leftBoundary)
        {
            transform.position = new Vector3(leftBoundary, transform.position.y, transform.position.z);
        }
        if (transform.position.x > rightBoundary)
        {
            transform.position = new Vector3(rightBoundary, transform.position.y, transform.position.z);
        }
        //Get the user input
        horizontalInput = Input.GetAxis("Horizontal");
        //Move the player
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
    }
}
