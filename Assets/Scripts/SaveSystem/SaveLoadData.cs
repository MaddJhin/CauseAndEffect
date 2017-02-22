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
    public string   m_sceneName;
    public string   m_timeDate;
    public string   m_description;
    public int      m_sampleInt;
    public float    m_sampleFloat;
    public bool     m_isBlank;

    // Default values for the save slot
    public SaveLoadData()
    {
        // This scene to load
        this.m_sceneName = "";

        // Sample String
        this.m_timeDate = "";

        // Sample String
        this.m_description = "";

        // Sample Int
        this.m_sampleInt = 0;

        // Sample Float
        this.m_sampleFloat = 0.0f;

        // Just a sample bool
        this.m_isBlank = true;
    }
}