using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carController : MonoBehaviour {
    
    public Rigidbody2D carRigidBody;
    public Rigidbody2D backTire;
    public Rigidbody2D frontTire;
    public float speed = 20;
    public float carTorque = 10;
    private float movement;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        backTire.AddTorque(-movement * speed * Time.fixedDeltaTime);
        frontTire.AddTorque(-movement * speed * Time.fixedDeltaTime);
        carRigidBody.AddTorque(-movement * carTorque * Time.fixedDeltaTime);
    }
}
