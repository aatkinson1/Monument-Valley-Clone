﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript: MonoBehaviour
{
	// Canvas
	public Canvas mainMenu;
	public Canvas optionsMenu;
	public Canvas exitMenu;

	// Buttons
	public Button startText;
	public Button optionsText;
	public Button exitText;
	public Button backText;

	void Start ()
	{
		mainMenu = mainMenu.GetComponent<Canvas> ();
		optionsMenu = optionsMenu.GetComponent<Canvas> ();
		exitMenu = exitMenu.GetComponent<Canvas> ();
		startText = startText.GetComponent<Button> ();
		optionsText = optionsText.GetComponent<Button> ();
		exitText = exitText.GetComponent<Button> ();

		// Disable exit and options menu
		optionsMenu.enabled = false;
		exitMenu.enabled = false;
	}

	// Function to bring up the Option menu
	public void OptionPress()
	{
		// On options press, main and exit menu are disabled
		mainMenu.enabled = false;
		optionsMenu.enabled = true;
		exitMenu.enabled = false;
	}

	// Function to go back to the main menu from the options menu
	public void BackPress()
	{
		// On back press, go back to main menu
		mainMenu.enabled = true;
		optionsMenu.enabled = false;
		exitMenu.enabled = false;
	}

	// Function to bring up the exit menu
	public void ExitPress()
	{
		// On exit press, exit menu is enabled, all else is disabled
		mainMenu.enabled = false;
		optionsMenu.enabled = false;
		exitMenu.enabled = true;
	}

	// Function to go back to main menu from the exit menu
	public void ExitNoPress()
	{
		// If player decides to continue to main menu
		mainMenu.enabled = true;
		optionsMenu.enabled = false;
		exitMenu.enabled = false;
	}

	// Function to exit game
	public void ExitGame()
	{
		// Exit game
		Application.Quit ();
	}

	// Function to load first level
	public void LoadLevel()
	{
		// Load the first level
		SceneManager.LoadScene ("Level 1");
	}
}