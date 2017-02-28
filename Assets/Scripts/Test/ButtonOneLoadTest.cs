using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonOneLoadTest : MonoBehaviour {

    private LevelSelectButton button;
        
    void Awake()
    {
        SaveLoad.Load();
        button = GetComponent<LevelSelectButton>();
        button.Star_One = SaveLoadManagement.m_current.level_001.m_star1;
        button.Star_Two = SaveLoadManagement.m_current.level_001.m_star2;
        button.Star_Three = SaveLoadManagement.m_current.level_001.m_star3;
    }

	// Use this for initialization
	void Start () {

    }
}
