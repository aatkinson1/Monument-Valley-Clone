using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2GuessEnter : MonoBehaviour 
{
	int count = 0; 

	void Update()
	{
		count = GameObject.Find ("Player_Mannequin_Blue").GetComponent<PlayerController> ().keyCount;
	}

	// On trigger, load level 2 - guess room
	void OnTriggerEnter (Collider col)
	{
		if (count == 1) 
		{
			SceneManager.LoadScene ("Level 2 - Guess Room");
		}
	}
}