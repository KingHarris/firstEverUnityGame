using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{

    public Transform target;
    private Vector3 offset;

    // Use this for initialization
    void Start()
    {
        offset = transform.position - target.position;
    }

    // Update is called once per frame
    void Update()
    {
		Vector3 tempPosition = transform.position;
		tempPosition = target.position + offset;
        transform.position = tempPosition;
    }
}