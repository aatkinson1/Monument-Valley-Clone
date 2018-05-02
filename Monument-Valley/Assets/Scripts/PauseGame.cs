using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseGame : MonoBehaviour {

   
    public Transform canvas;

    // Canvas
    public Canvas pauseMenu;

    // Buttons
    public Button resume;
    public Button quit;
    public Button back;

    void Start()
    {
        //Initialize pause menu
        pauseMenu = pauseMenu.GetComponent<Canvas>();

        // Initialize pause menu buttons
        resume = resume.GetComponent<Button>();
        quit = quit.GetComponent<Button>();
        back = back.GetComponent<Button>();
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
    }

    // Pauses the game
    public void Pause()
    {
        if (canvas.gameObject.activeInHierarchy == false)
        {
            canvas.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            canvas.gameObject.SetActive(false);
            Time.timeScale = 1;
        }
    }

    public void ResumePress()
    {
        pauseMenu.enabled = false;
        Time.timeScale = 1;
        Debug.Log("Resume pressed");
    }

    public void BackPress()
    {
        pauseMenu.enabled = false;
        Time.timeScale = 1;
        Debug.Log("Back pressed");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Player pressed quit");
    }
}
