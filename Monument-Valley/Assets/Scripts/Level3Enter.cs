﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level3Enter : MonoBehaviour 
{
	int count = 0; 

	void Update()
	{
		count = GameObject.Find ("Player_Mannequin_Blue").GetComponent<PlayerController> ().keyCount;
		Debug.Log (count);
	}

	// On trigger, load level 2
	void OnTriggerEnter (Collider col)
	{
		if (count == 1) 
		{
			SceneManager.LoadScene ("Level 3");
		}
	}
}
