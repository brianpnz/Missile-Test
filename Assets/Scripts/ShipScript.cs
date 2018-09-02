using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipScript : MonoBehaviour {

    public float thrust = 3;
    public float RotationSpeed = 80;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Get the key press values
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        //Apply the force in the direction the ship is moving
        Vector3 movement = new Vector3(0.0f, moveVertical, 0.0f);
        rb.AddRelativeForce(movement * thrust);

        //Rotate the ship along the UP axis
        Vector3 rotation = new Vector3(0.0f, 0.0f, moveHorizontal);
        transform.Rotate(rotation * 80 * Time.deltaTime);
    }
}
