using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelOneSaveTest : MonoBehaviour {


	void OnCollisionEnter2D()
    {
        SaveLoadManagement.m_current.level_002.m_unlocked = true;
        SaveLoadManagement.m_current.level_001.m_star1 = true;
        SaveLoadManagement.m_current.level_001.m_star2 = true;
        SaveLoadManagement.m_current.level_001.m_star3 = true;

        SaveLoad.Save();
    }
}
