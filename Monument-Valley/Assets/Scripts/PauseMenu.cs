using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour 
{
	public Transform PauseMenuCanvas;
	public GameObject Player;

	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Escape))
		{
			Pause ();
		}
	}

	public void Pause ()
	{
		if (PauseMenuCanvas.gameObject.activeInHierarchy == false) 
		{
			PauseMenuCanvas.gameObject.SetActive (true);
			Time.timeScale = 0;
			Player.GetComponent<PlayerController>().enabled = false;
		} 
		else 
		{
			PauseMenuCanvas.gameObject.SetActive (false);
			Time.timeScale = 1;
			Player.GetComponent<PlayerController>().enabled = true;
		}
	}

	public void Exit ()
	{
		Application.Quit ();
	}
}
