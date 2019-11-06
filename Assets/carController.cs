using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carController : MonoBehaviour {
    
    public Rigidbody2D carRigidBody;
	public WheelJoint2D backTire;
	public bool backTirePropulsion;
	private JointMotor2D backTireMotor;
	public WheelJoint2D frontTire;
	public bool frontTirePropulsion;

	private JointMotor2D frontTireMotor;

    public float speed = 20;
    public float carTorque = 10;
    private float movement;
    
    void Start()
    {
        frontTireMotor = frontTire.motor;
		backTireMotor = backTire.motor;
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal");
		float tireSpeed = movement * speed;
		Debug.Log("TireSpeed: " + tireSpeed);
		if(frontTirePropulsion){
			frontTireMotor.motorSpeed = tireSpeed;
			frontTire.motor = frontTireMotor;
		}
		if(backTirePropulsion){
			backTireMotor.motorSpeed = tireSpeed;
			backTire.motor = backTireMotor;
		}
    }
}
