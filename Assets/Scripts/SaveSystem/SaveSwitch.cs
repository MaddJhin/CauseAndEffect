using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SaveSwitch
{
    
    public static void UpdateStars(string levelName, int starIndex)
    {

        //if (SaveLoadManagement.m_current == null)
        //    SaveLoadManagement.m_current = new SaveLoadManagement();

        switch (levelName)
        {
            case "Level_001":
                SaveLoadManagement.m_current.level_002.m_unlocked = true;
                if (starIndex == 0)
                    SaveLoadManagement.m_current.level_001.m_star1 = true;
                else if (starIndex == 1)
                    SaveLoadManagement.m_current.level_001.m_star2 = true;
                else if(starIndex == 2)
                    SaveLoadManagement.m_current.level_001.m_star3 = true;
                break;
            case "Level_002":
                SaveLoadManagement.m_current.level_003.m_unlocked = true;
                if (starIndex == 0)
                    SaveLoadManagement.m_current.level_002.m_star1 = true;
                else if(starIndex == 1)
                    SaveLoadManagement.m_current.level_002.m_star2 = true;
                else if (starIndex == 2)
                    SaveLoadManagement.m_current.level_002.m_star3 = true;            
                break;
            case "Level_003":
                SaveLoadManagement.m_current.level_004.m_unlocked = true;
                if (starIndex == 0)
                    SaveLoadManagement.m_current.level_003.m_star1 = true;
                else if (starIndex == 1)
                    SaveLoadManagement.m_current.level_003.m_star2 = true;
                else if (starIndex == 2)
                    SaveLoadManagement.m_current.level_003.m_star3 = true;
                break;
            case "Level_004":
                SaveLoadManagement.m_current.level_005.m_unlocked = true;
                if (starIndex == 0)
                    SaveLoadManagement.m_current.level_004.m_star1 = true;
                else if (starIndex == 1)
                    SaveLoadManagement.m_current.level_004.m_star2 = true;
                else if (starIndex == 2)
                SaveLoadManagement.m_current.level_004.m_star3 = true;
                break;
            case "Level_005":
                SaveLoadManagement.m_current.level_006.m_unlocked = true;
                if (starIndex == 0)
                    SaveLoadManagement.m_current.level_005.m_star1 = true;
                else if (starIndex == 1)
                    SaveLoadManagement.m_current.level_005.m_star2 = true;
                else if (starIndex == 2)
                    SaveLoadManagement.m_current.level_005.m_star3 = true;
                break;
            case "Level_006":
                SaveLoadManagement.m_current.level_007.m_unlocked = true;
                if (starIndex == 0)
                    SaveLoadManagement.m_current.level_006.m_star1 = true;
                else if (starIndex == 1)
                    SaveLoadManagement.m_current.level_006.m_star2 = true;
                else if (starIndex == 2)
                    SaveLoadManagement.m_current.level_006.m_star3 = true;
                break;
            case "Level_007":
                SaveLoadManagement.m_current.level_008.m_unlocked = true;
                if (starIndex == 0)
                    SaveLoadManagement.m_current.level_007.m_star1 = true;
                else if (starIndex == 1)
                    SaveLoadManagement.m_current.level_007.m_star2 = true;
                else if (starIndex == 2)
                    SaveLoadManagement.m_current.level_007.m_star3 = true;
                 break;
            case "Level_008":
                SaveLoadManagement.m_current.level_009.m_unlocked = true;
                if (starIndex == 0)
                    SaveLoadManagement.m_current.level_008.m_star1 = true;
                else if (starIndex == 1)
                    SaveLoadManagement.m_current.level_008.m_star2 = true;
                else if (starIndex == 2)
                    SaveLoadManagement.m_current.level_008.m_star3 = true;
                break;
            case "Level_009":
                SaveLoadManagement.m_current.level_010.m_unlocked = true;
                if (starIndex == 0)
                    SaveLoadManagement.m_current.level_008.m_star1 = true;
                else if (starIndex == 1)
                    SaveLoadManagement.m_current.level_008.m_star2 = true;
                else if (starIndex == 2)
                    SaveLoadManagement.m_current.level_008.m_star3 = true;
                break;
            case "Level_010":
                SaveLoadManagement.m_current.level_011.m_unlocked = true;
                if (starIndex == 0)
                    SaveLoadManagement.m_current.level_009.m_star1 = true;
                else if (starIndex == 1)
                    SaveLoadManagement.m_current.level_009.m_star2 = true;
                else if (starIndex == 2)
                    SaveLoadManagement.m_current.level_009.m_star3 = true;
                break;
            case "Level_011":
                SaveLoadManagement.m_current.level_012.m_unlocked = true;
                if (starIndex == 0)
                    SaveLoadManagement.m_current.level_010.m_star1 = true;
                else if (starIndex == 1)
                    SaveLoadManagement.m_current.level_010.m_star2 = true;
                else if (starIndex == 2)
                    SaveLoadManagement.m_current.level_010.m_star3 = true;
                break;
            case "Level_012":
                SaveLoadManagement.m_current.level_013.m_unlocked = true;
                if (starIndex == 0)
                    SaveLoadManagement.m_current.level_011.m_star1 = true;
                else if (starIndex == 1)
                    SaveLoadManagement.m_current.level_011.m_star2 = true;
                else if (starIndex == 2)
                    SaveLoadManagement.m_current.level_011.m_star3 = true;
                break;
            case "Level_013":
                SaveLoadManagement.m_current.level_014.m_unlocked = true;
                if (starIndex == 0)
                    SaveLoadManagement.m_current.level_013.m_star1 = true;
                else if (starIndex == 1)
                    SaveLoadManagement.m_current.level_013.m_star2 = true;
                else if (starIndex == 2)
                    SaveLoadManagement.m_current.level_013.m_star3 = true;
                break;
            case "Level_014":
                SaveLoadManagement.m_current.level_015.m_unlocked = true;
                if (starIndex == 0)
                    SaveLoadManagement.m_current.level_014.m_star1 = true;
                else if (starIndex == 1)
                    SaveLoadManagement.m_current.level_014.m_star2 = true;
                else if (starIndex == 2)
                    SaveLoadManagement.m_current.level_014.m_star3 = true;
                break;
            case "Level_015":
                SaveLoadManagement.m_current.level_016.m_unlocked = true;
                if (starIndex == 0)
                    SaveLoadManagement.m_current.level_015.m_star1 = true;
                else if (starIndex == 1)
                    SaveLoadManagement.m_current.level_015.m_star2 = true;
                else if (starIndex == 2)
                    SaveLoadManagement.m_current.level_015.m_star3 = true;
                break;
            case "Level_016":
                SaveLoadManagement.m_current.level_017.m_unlocked = true;
                if (starIndex == 0)
                    SaveLoadManagement.m_current.level_016.m_star1 = true;
                else if (starIndex == 1)
                    SaveLoadManagement.m_current.level_016.m_star2 = true;
                else if (starIndex == 2)
                    SaveLoadManagement.m_current.level_016.m_star3 = true;
                break;
            case "Level_017":
                SaveLoadManagement.m_current.level_018.m_unlocked = true;
                if (starIndex == 0)
                    SaveLoadManagement.m_current.level_017.m_star1 = true;
                else if (starIndex == 1)
                    SaveLoadManagement.m_current.level_017.m_star2 = true;
                else if (starIndex == 2)
                    SaveLoadManagement.m_current.level_017.m_star3 = true;
                break;
            case "Level_018":
                SaveLoadManagement.m_current.level_019.m_unlocked = true;
                if (starIndex == 0)
                    SaveLoadManagement.m_current.level_018.m_star1 = true;
                else if (starIndex == 1)
                    SaveLoadManagement.m_current.level_018.m_star2 = true;
                else if (starIndex == 2)
                    SaveLoadManagement.m_current.level_018.m_star3 = true;
                break;
            case "Level_019":
                SaveLoadManagement.m_current.level_020.m_unlocked = true;
                if (starIndex == 0)
                    SaveLoadManagement.m_current.level_019.m_star1 = true;
                else if (starIndex == 1)
                    SaveLoadManagement.m_current.level_019.m_star2 = true;
                else if (starIndex == 2)
                    SaveLoadManagement.m_current.level_019.m_star3 = true;
                break;
            case "Level_020":
                SaveLoadManagement.m_current.level_021.m_unlocked = true;
                if (starIndex == 0)
                    SaveLoadManagement.m_current.level_020.m_star1 = true;
                else if (starIndex == 1)
                    SaveLoadManagement.m_current.level_020.m_star2 = true;
                else if (starIndex == 2)
                    SaveLoadManagement.m_current.level_020.m_star3 = true;
                break;
            case "Level_021":
                SaveLoadManagement.m_current.level_022.m_unlocked = true;
                if (starIndex == 0)
                    SaveLoadManagement.m_current.level_021.m_star1 = true;
                else if (starIndex == 1)
                    SaveLoadManagement.m_current.level_021.m_star2 = true;
                else if (starIndex == 2)
                    SaveLoadManagement.m_current.level_021.m_star3 = true;
                break;
            case "Level_022":
                SaveLoadManagement.m_current.level_023.m_unlocked = true;
                if (starIndex == 0)
                    SaveLoadManagement.m_current.level_022.m_star1 = true;
                else if (starIndex == 1)
                    SaveLoadManagement.m_current.level_022.m_star2 = true;
                else if (starIndex == 2)
                    SaveLoadManagement.m_current.level_022.m_star3 = true;
                break;
            case "Level_023":
                SaveLoadManagement.m_current.level_024.m_unlocked = true;
                if (starIndex == 0)
                    SaveLoadManagement.m_current.level_023.m_star1 = true;
                else if (starIndex == 1)
                    SaveLoadManagement.m_current.level_023.m_star2 = true;
                else if (starIndex == 2)
                    SaveLoadManagement.m_current.level_023.m_star3 = true;
                break;
            case "Level_024":
                SaveLoadManagement.m_current.level_025.m_unlocked = true;
                if (starIndex == 0)
                    SaveLoadManagement.m_current.level_024.m_star1 = true;
                else if (starIndex == 1)
                    SaveLoadManagement.m_current.level_024.m_star2 = true;
                else if (starIndex == 2)
                    SaveLoadManagement.m_current.level_024.m_star3 = true;
                break;
            case "Level_025":
                SaveLoadManagement.m_current.level_026.m_unlocked = true;
                if (starIndex == 0)
                    SaveLoadManagement.m_current.level_025.m_star1 = true;
                else if (starIndex == 1)
                    SaveLoadManagement.m_current.level_025.m_star2 = true;
                else if (starIndex == 2)
                    SaveLoadManagement.m_current.level_025.m_star3 = true;
                break;
            case "Level_026":
                SaveLoadManagement.m_current.level_027.m_unlocked = true;
                if (starIndex == 0)
                    SaveLoadManagement.m_current.level_026.m_star1 = true;
                else if (starIndex == 1)
                    SaveLoadManagement.m_current.level_026.m_star2 = true;
                else if (starIndex == 2)
                    SaveLoadManagement.m_current.level_026.m_star3 = true;
                break;
            case "Level_027":
                SaveLoadManagement.m_current.level_028.m_unlocked = true;
                if (starIndex == 0)
                    SaveLoadManagement.m_current.level_027.m_star1 = true;
                else if (starIndex == 1)
                    SaveLoadManagement.m_current.level_027.m_star2 = true;
                else if (starIndex == 2)
                    SaveLoadManagement.m_current.level_027.m_star3 = true;
                break;
            case "Level_028":
                SaveLoadManagement.m_current.level_029.m_unlocked = true;
                if (starIndex == 0)
                    SaveLoadManagement.m_current.level_028.m_star1 = true;
                else if (starIndex == 1)
                    SaveLoadManagement.m_current.level_028.m_star2 = true;
                else if (starIndex == 2)
                    SaveLoadManagement.m_current.level_028.m_star3 = true;
                break;
            case "Level_029":
                SaveLoadManagement.m_current.level_030.m_unlocked = true;
                if (starIndex == 0)
                    SaveLoadManagement.m_current.level_029.m_star1 = true;
                else if (starIndex == 1)
                    SaveLoadManagement.m_current.level_029.m_star2 = true;
                else if (starIndex == 2)
                    SaveLoadManagement.m_current.level_029.m_star3 = true;
                break;
            case "Level_030":
                //SaveLoadManagement.m_current.level_030.m_unlocked = true;
                if (starIndex == 0)
                    SaveLoadManagement.m_current.level_030.m_star1 = true;
                else if (starIndex == 1)
                    SaveLoadManagement.m_current.level_030.m_star2 = true;
                else if (starIndex == 2)
                    SaveLoadManagement.m_current.level_030.m_star3 = true;
                break;
            default:
                Debug.Log("Wrong Case, No star updated");
                break;
        }

        SaveLoad.Save();
        Debug.Log("Save Switch has Saved");
    }
}
