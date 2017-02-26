using UnityEngine;
using System.Collections;

/*
    Author: Keisuke Miyazaki
    Date: December 2, 2016
    E-mail: mintymiyazaki@yahoo.co.jp
    Purpose: To provide a save system for CelleC C# Unity Projects
    Notes: Available in C++, C#, and Java, English, Japanese, and Mandarin upon request

    Description: This is just a template for the save data pertaining to user settings. Think of this as a save slot.
    All these are absolutely optional, this is just an example.
*/

[System.Serializable]
public class SaveLoadData
{
    // An assortment of sample data types.
    public string   levelName;
    public bool     m_unlocked;
    public bool m_star1;
    public bool m_star2;
    public bool m_star3;
    
    // Default values for the save slot
    public SaveLoadData()
    {
        // This scene to load
        this.levelName = "";

        m_unlocked = m_star1 = m_star2 = m_star3 = false;
    }
}