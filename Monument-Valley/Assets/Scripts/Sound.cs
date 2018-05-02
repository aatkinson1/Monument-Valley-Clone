using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sound : MonoBehaviour {

    private Music music;
    public Button sound;
    public Transform soundOFF;
    public Transform soundON;

	// Use this for initialization
	void Start () {
        music = GameObject.FindObjectOfType<Music>();
        UpdateIcon();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PauseMusic()
    {
        music.ToggleSound();
        UpdateIcon();
    }

    void UpdateIcon()
    {
        if(PlayerPrefs.GetInt("Muted", 0) == 0)
        {
            AudioListener.volume = 1;
            if (soundON.gameObject.activeInHierarchy == false && soundOFF.gameObject.activeInHierarchy == true)
            {
                soundON.gameObject.SetActive(true);
                soundOFF.gameObject.SetActive(false);
            }
        }
        else
        {
            AudioListener.volume = 0;
            if (soundOFF.gameObject.activeInHierarchy == false && soundON.gameObject.activeInHierarchy == true)
            {
                soundOFF.gameObject.SetActive(true);
                soundON.gameObject.SetActive(false);
            }
        }
    }
}
