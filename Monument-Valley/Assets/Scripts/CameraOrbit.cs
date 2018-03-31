using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOrbit : MonoBehaviour {

	public Transform target;	// Target
	private float speedMod = 0.5f;	// Speed modifier
	private Vector3 point;	// Coordinate point

	// Use this for initialization
	void Start () 
	{
		point = target.transform.position;	// Get target's position
		transform.LookAt(point);
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.RotateAround (point, new Vector3 (0.0f, 1.0f, 0.0f), 10 * Time.deltaTime * speedMod);
	}
}
