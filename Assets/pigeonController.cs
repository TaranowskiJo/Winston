using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pigeonController : MonoBehaviour
{
    
    public float speed = 45.0f; //want steady pace but not so fast it feels unfair
    public float turnSpeed = 75.0f; //extra turn speed to add precision aspect with user input but also a degree of wildness which feels appropriate for our litle pigeon
    public float horizontalInput;
    public float forwardInput;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //get our axis' using...
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");


        //move pige forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        //rotates pige based on horizontal input
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        // transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        
        //rotate as spin? 
        // transform.Rotate(Vector3.up, speed * forwardInput * Time.deltaTime);

    }
    
        private void OnTrigger(Collision collision)
        {
            print("Colliding!");
        }
}


//============================//
//======State Management =====//
//============================//

