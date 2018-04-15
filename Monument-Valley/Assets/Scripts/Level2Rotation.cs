using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2Rotation : MonoBehaviour {

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("left"))
        {
            //rotatingClockwise = !rotatingClockwise;
            transform.Rotate(0, -90, 0);
        }
        if (Input.GetKeyDown("right"))
        {
            //rotatingClockwise = !rotatingClockwise;
            transform.Rotate(0, 90, 0);
        }
        if (Input.GetKeyDown("up"))
        {
            transform.position = GameObject.FindGameObjectWithTag("Position2").transform.position;
        }
        if (Input.GetKeyDown("down"))
        {
            transform.position = GameObject.FindGameObjectWithTag("Position1").transform.position;
        }
    }
}
