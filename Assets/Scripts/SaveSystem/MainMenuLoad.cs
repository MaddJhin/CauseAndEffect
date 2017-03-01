using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuLoad : MonoBehaviour {

	// Use this for initialization
	void Start () {

        if (SaveLoadManagement.m_current == null)
            SaveLoadManagement.m_current = new SaveLoadManagement();

        SaveLoad.Load();
	}

    public void Button_Play()
    {

        if (GameSoundScript.instance != null)
            GameSoundScript.instance.playUIButton();
        
        SceneManager.LoadScene(SaveSwitch.latestLevel);
    }
}
