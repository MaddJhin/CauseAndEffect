using UnityEngine;
using System.Collections;

/*
    Author: Keisuke Miyazaki
    Date: December 2, 2016
    E-mail: mintymiyazaki@yahoo.co.jp
    Purpose: To provide a save system for CelleC C# Unity Projects
    Notes: Available in C++, C#, and Java, English, Japanese, and Mandarin upon request

    Description: This is where the information that will be sent to the SaveLoad.cs script
*/

[System.Serializable]
public class SaveLoadManagement
{
    // This is the current status of the game
    public static SaveLoadManagement m_current;

    // Consider these data slots. 
    // You can have as many as you want, just don't turn this into an array or it will break things.
    public SaveLoadData level_001, level_002, level_003, level_004, level_005, level_006, level_007, level_008, level_009, level_010, level_011, level_012, level_013, level_014, level_015,
        level_016, level_017, level_018, level_019, level_020, level_021, level_022, level_023, level_024, level_025, level_026, level_027, level_028, level_029, level_030;

    // Consider this the data slot for user settings
    // You can have as many of these as you like if you want to save different settings for different users.
    // All the data here can easily be put into SaveLoadData, but for the sake of an example, this is just an example for using multiple
    // save files.
    public SaveLoadSettings m_settingsData;

    // I just have this here as a paranoid check.
    public static int m_loadSlot = -1;

    // Assigning each data slot with information if it exists.
    public SaveLoadManagement()
    {

        level_001 = new SaveLoadData();
        level_002 = new SaveLoadData();
        level_003 = new SaveLoadData();
        level_004 = new SaveLoadData();
        level_005 = new SaveLoadData();
        level_006 = new SaveLoadData();
        level_007 = new SaveLoadData();
        level_008 = new SaveLoadData();
        level_009 = new SaveLoadData();
        level_010 = new SaveLoadData();
        level_011 = new SaveLoadData();
        level_012 = new SaveLoadData();
        level_013 = new SaveLoadData();
        level_014 = new SaveLoadData();
        level_015 = new SaveLoadData();
        level_016 = new SaveLoadData();
        level_017 = new SaveLoadData();
        level_018 = new SaveLoadData();
        level_019 = new SaveLoadData();
        level_020 = new SaveLoadData();
        level_021 = new SaveLoadData();
        level_022 = new SaveLoadData();
        level_023 = new SaveLoadData();
        level_024 = new SaveLoadData();
        level_025 = new SaveLoadData();
        level_026 = new SaveLoadData();
        level_027 = new SaveLoadData();
        level_028 = new SaveLoadData();
        level_029 = new SaveLoadData();
        level_030 = new SaveLoadData();


        // Game Settings slot.
        m_settingsData = new SaveLoadSettings();
    }

    /* Sample Code

    // This is how you access the current game information

    // Storing a saved value

    string sampleString;
    sampleString = SaveLoadManagement.m_current.m_data1.sceneName;

    // Writing to a saved value

    sampleString = "Cake";
    SaveLoadManagement.m_current.mdata1.sceneName = sampleString;

    // To Save Data write
    SaveLoad.Save();

    // To Load Data write
    SaveLoad.Load();

    */
}