using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuLoad : MonoBehaviour {

	// Use this for initialization
	void Start () {

        if (SaveLoadManagement.m_current == null)
            SaveLoadManagement.m_current = new SaveLoadManagement();

        SaveLoad.Load();
	}
}
