using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    int count = 1;
    bool shouldPrintOver20 = true;
    bool shouldPrintOver30 = true;

    float startingPoint;
    SphereCollider myCollider;

	// Use this for initialization
	void Start () {

      

        Debug.Log("Start");
        startingPoint = transform.position.z;
        
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up*300);
        }

        float distance;
        distance = transform.position.z - startingPoint;
        
        if(distance > 30)
        {
            if(shouldPrintOver30)
            {
                Debug.Log("Over 30;" + distance);
                shouldPrintOver30 = false;
            }
        }
        else if (distance >20)
        {
            if (shouldPrintOver20)
            {
                Debug.Log("Over 20;" + distance);
                shouldPrintOver20 = false;
            }
        }

    }



}
