using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

    //private bool rotatingClockwise = false;
    //private bool keyPressed = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//if (rotatingClockwise) //&& (transform.eulerAngles.x > 90 || transform.eulerAngles.x <= 0))
        //{
        //    transform.Rotate(90, 0, 0);
        //}
        //else if (!rotatingClockwise) //&& transform.eulerAngles.x > 0)
        //{
        //    transform.Rotate(-90, 0, 0);
        //}

        if (Input.GetKeyDown("left"))
        {
            //rotatingClockwise = !rotatingClockwise;
            transform.Rotate(90, 0, 0);
        }
        if (Input.GetKeyDown("right"))
        {
            //rotatingClockwise = !rotatingClockwise;
            transform.Rotate(-90, 0, 0);
        }
    }

    
}
