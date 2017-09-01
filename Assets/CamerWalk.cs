using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CamerWalk : MonoBehaviour {
    GameObject ball;
    // Use this for initialization
    void Start() {
        ball = GameObject.Find("Ball");


      GameObject[] coins = GameObject.FindGameObjectsWithTag("Coin");


        for(int i = 0;i < coins.Length; i++)
        {

            Debug.Log(coins[i].name);
        }


        //Debug.Log(coins[4].name);
    }
	
	// Update is called once per frame
	void Update () {
   
        transform.position = new Vector3(0, 
            ball.transform.position.y+3,
            ball.transform.position.z - 14);
	}
}
