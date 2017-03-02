using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class LevelSelectUnlock : MonoBehaviour {


    public LevelSelectButton[] levelButtons;

    void Awake()
    {
        SetButtons();
    }

    void SetButtons()
    {
        if (SaveLoadManagement.m_current == null)
            SaveLoadManagement.m_current = new SaveLoadManagement();

        SaveLoad.Load();

        Debug.Log("m_current is null is: " + SaveLoadManagement.m_current == null);
        Debug.Log(SaveLoadManagement.m_current.level_001 == null);
        foreach (LevelSelectButton button in levelButtons)
        {
            string buttonName = button.name;
            
            switch (buttonName)
            {
                case "Level_001":
//                    SaveLoadManagement.m_current.level_001.m_unlocked = true;
                    //button.unlocked = SaveLoadManagement.m_current.level_001.m_unlocked;
                    button.Star_One = SaveLoadManagement.m_current.level_001.m_star1;
                    button.Star_Two = SaveLoadManagement.m_current.level_001.m_star2;
                    button.Star_Three = SaveLoadManagement.m_current.level_001.m_star3;
                    break;
                case "Level_002":
                    button.unlocked = SaveLoadManagement.m_current.level_002.m_unlocked;
                    button.Star_One = SaveLoadManagement.m_current.level_002.m_star1;
                    button.Star_Two = SaveLoadManagement.m_current.level_002.m_star2;
                    button.Star_Three = SaveLoadManagement.m_current.level_002.m_star3;
                    break;
                case "Level_003":
                    button.unlocked = SaveLoadManagement.m_current.level_003.m_unlocked;
                    button.Star_One = SaveLoadManagement.m_current.level_003.m_star1;
                    button.Star_Two = SaveLoadManagement.m_current.level_003.m_star2;
                    button.Star_Three = SaveLoadManagement.m_current.level_003.m_star3;
                    break;
                case "Level_004":
                    button.unlocked = SaveLoadManagement.m_current.level_004.m_unlocked;
                    button.Star_One = SaveLoadManagement.m_current.level_004.m_star1;
                    button.Star_Two = SaveLoadManagement.m_current.level_004.m_star2;
                    button.Star_Three = SaveLoadManagement.m_current.level_004.m_star3;
                    break;
                case "Level_005":
                    button.unlocked = SaveLoadManagement.m_current.level_005.m_unlocked;
                    button.Star_One = SaveLoadManagement.m_current.level_005.m_star1;
                    button.Star_Two = SaveLoadManagement.m_current.level_005.m_star2;
                    button.Star_Three = SaveLoadManagement.m_current.level_005.m_star3;
                    break;
                case "Level_006":
                    button.unlocked = SaveLoadManagement.m_current.level_006.m_unlocked;
                    button.Star_One = SaveLoadManagement.m_current.level_006.m_star1;
                    button.Star_Two = SaveLoadManagement.m_current.level_006.m_star2;
                    button.Star_Three = SaveLoadManagement.m_current.level_006.m_star3;
                    break;
                case "Level_007":
                    button.unlocked = SaveLoadManagement.m_current.level_007.m_unlocked;
                    button.Star_One = SaveLoadManagement.m_current.level_007.m_star1;
                    button.Star_Two = SaveLoadManagement.m_current.level_007.m_star2;
                    button.Star_Three = SaveLoadManagement.m_current.level_007.m_star3;
                    break;
                case "Level_008":
                    button.unlocked = SaveLoadManagement.m_current.level_008.m_unlocked;
                    button.Star_One = SaveLoadManagement.m_current.level_008.m_star1;
                    button.Star_Two = SaveLoadManagement.m_current.level_008.m_star2;
                    button.Star_Three = SaveLoadManagement.m_current.level_008.m_star3;
                    break;
                case "Level_009":
                    button.unlocked = SaveLoadManagement.m_current.level_009.m_unlocked;
                    button.Star_One = SaveLoadManagement.m_current.level_009.m_star1;
                    button.Star_Two = SaveLoadManagement.m_current.level_009.m_star2;
                    button.Star_Three = SaveLoadManagement.m_current.level_009.m_star3;
                    break;
                case "Level_010":
                    button.unlocked = SaveLoadManagement.m_current.level_010.m_unlocked;
                    button.Star_One = SaveLoadManagement.m_current.level_010.m_star1;
                    button.Star_Two = SaveLoadManagement.m_current.level_010.m_star2;
                    button.Star_Three = SaveLoadManagement.m_current.level_010.m_star3;
                    break;
                case "Level_011":
                    button.unlocked = SaveLoadManagement.m_current.level_011.m_unlocked;
                    button.Star_One = SaveLoadManagement.m_current.level_011.m_star1;
                    button.Star_Two = SaveLoadManagement.m_current.level_011.m_star2;
                    button.Star_Three = SaveLoadManagement.m_current.level_011.m_star3;
                    break;
                case "Level_012":
                    button.unlocked = SaveLoadManagement.m_current.level_012.m_unlocked;
                    button.Star_One = SaveLoadManagement.m_current.level_012.m_star1;
                    button.Star_Two = SaveLoadManagement.m_current.level_012.m_star2;
                    button.Star_Three = SaveLoadManagement.m_current.level_012.m_star3;
                    break;
                case "Level_013":
                    button.unlocked = SaveLoadManagement.m_current.level_013.m_unlocked;
                    button.Star_One = SaveLoadManagement.m_current.level_013.m_star1;
                    button.Star_Two = SaveLoadManagement.m_current.level_013.m_star2;
                    button.Star_Three = SaveLoadManagement.m_current.level_013.m_star3;
                    break;
                case "Level_014":
                    button.unlocked = SaveLoadManagement.m_current.level_014.m_unlocked;
                    button.Star_One = SaveLoadManagement.m_current.level_014.m_star1;
                    button.Star_Two = SaveLoadManagement.m_current.level_014.m_star2;
                    button.Star_Three = SaveLoadManagement.m_current.level_014.m_star3;
                    break;
                case "Level_015":
                    button.unlocked = SaveLoadManagement.m_current.level_015.m_unlocked;
                    button.Star_One = SaveLoadManagement.m_current.level_015.m_star1;
                    button.Star_Two = SaveLoadManagement.m_current.level_015.m_star2;
                    button.Star_Three = SaveLoadManagement.m_current.level_015.m_star3;
                    break;
                case "Level_016":
                    button.unlocked = SaveLoadManagement.m_current.level_016.m_unlocked;
                    button.Star_One = SaveLoadManagement.m_current.level_016.m_star1;
                    button.Star_Two = SaveLoadManagement.m_current.level_016.m_star2;
                    button.Star_Three = SaveLoadManagement.m_current.level_016.m_star3;
                    break;
                case "Level_017":
                    button.unlocked = SaveLoadManagement.m_current.level_017.m_unlocked;
                    button.Star_One = SaveLoadManagement.m_current.level_017.m_star1;
                    button.Star_Two = SaveLoadManagement.m_current.level_017.m_star2;
                    button.Star_Three = SaveLoadManagement.m_current.level_017.m_star3;
                    break;
                case "Level_018":
                    button.unlocked = SaveLoadManagement.m_current.level_018.m_unlocked;
                    button.Star_One = SaveLoadManagement.m_current.level_018.m_star1;
                    button.Star_Two = SaveLoadManagement.m_current.level_018.m_star2;
                    button.Star_Three = SaveLoadManagement.m_current.level_018.m_star3;
                    break;
                case "Level_019":
                    button.unlocked = SaveLoadManagement.m_current.level_019.m_unlocked;
                    button.Star_One = SaveLoadManagement.m_current.level_019.m_star1;
                    button.Star_Two = SaveLoadManagement.m_current.level_019.m_star2;
                    button.Star_Three = SaveLoadManagement.m_current.level_019.m_star3;
                    break;
                case "Level_020":
                    button.unlocked = SaveLoadManagement.m_current.level_020.m_unlocked;
                    button.Star_One = SaveLoadManagement.m_current.level_020.m_star1;
                    button.Star_Two = SaveLoadManagement.m_current.level_020.m_star2;
                    button.Star_Three = SaveLoadManagement.m_current.level_020.m_star3;
                    break;
                case "Level_021":
                    button.unlocked = SaveLoadManagement.m_current.level_021.m_unlocked;
                    button.Star_One = SaveLoadManagement.m_current.level_021.m_star1;
                    button.Star_Two = SaveLoadManagement.m_current.level_021.m_star2;
                    button.Star_Three = SaveLoadManagement.m_current.level_021.m_star3;
                    break;
                case "Level_022":
                    button.unlocked = SaveLoadManagement.m_current.level_022.m_unlocked;
                    button.Star_One = SaveLoadManagement.m_current.level_022.m_star1;
                    button.Star_Two = SaveLoadManagement.m_current.level_022.m_star2;
                    button.Star_Three = SaveLoadManagement.m_current.level_022.m_star3;
                    break;
                case "Level_023":
                    button.unlocked = SaveLoadManagement.m_current.level_023.m_unlocked;
                    button.Star_One = SaveLoadManagement.m_current.level_023.m_star1;
                    button.Star_Two = SaveLoadManagement.m_current.level_023.m_star2;
                    button.Star_Three = SaveLoadManagement.m_current.level_023.m_star3;
                    break;
                case "Level_024":
                    button.unlocked = SaveLoadManagement.m_current.level_024.m_unlocked;
                    button.Star_One = SaveLoadManagement.m_current.level_024.m_star1;
                    button.Star_Two = SaveLoadManagement.m_current.level_024.m_star2;
                    button.Star_Three = SaveLoadManagement.m_current.level_024.m_star3;
                    break;
                case "Level_025":
                    button.unlocked = SaveLoadManagement.m_current.level_025.m_unlocked;
                    button.Star_One = SaveLoadManagement.m_current.level_025.m_star1;
                    button.Star_Two = SaveLoadManagement.m_current.level_025.m_star2;
                    button.Star_Three = SaveLoadManagement.m_current.level_025.m_star3;
                    break;
                case "Level_026":
                    button.unlocked = SaveLoadManagement.m_current.level_026.m_unlocked;
                    button.Star_One = SaveLoadManagement.m_current.level_026.m_star1;
                    button.Star_Two = SaveLoadManagement.m_current.level_026.m_star2;
                    button.Star_Three = SaveLoadManagement.m_current.level_026.m_star3;
                    break;
                case "Level_027":
                    button.unlocked = SaveLoadManagement.m_current.level_027.m_unlocked;
                    button.Star_One = SaveLoadManagement.m_current.level_027.m_star1;
                    button.Star_Two = SaveLoadManagement.m_current.level_027.m_star2;
                    button.Star_Three = SaveLoadManagement.m_current.level_027.m_star3;
                    break;
                case "Level_028":
                    button.unlocked = SaveLoadManagement.m_current.level_028.m_unlocked;
                    button.Star_One = SaveLoadManagement.m_current.level_028.m_star1;
                    button.Star_Two = SaveLoadManagement.m_current.level_028.m_star2;
                    button.Star_Three = SaveLoadManagement.m_current.level_028.m_star3;
                    break;
                case "Level_029":
                    button.unlocked = SaveLoadManagement.m_current.level_029.m_unlocked;
                    button.Star_One = SaveLoadManagement.m_current.level_029.m_star1;
                    button.Star_Two = SaveLoadManagement.m_current.level_029.m_star2;
                    button.Star_Three = SaveLoadManagement.m_current.level_029.m_star3;
                    break;
                case "Level_030":
                    button.unlocked = SaveLoadManagement.m_current.level_030.m_unlocked;
                    button.Star_One = SaveLoadManagement.m_current.level_030.m_star1;
                    button.Star_Two = SaveLoadManagement.m_current.level_030.m_star2;
                    button.Star_Three = SaveLoadManagement.m_current.level_030.m_star3;
                    break;
                default:
                    Debug.Log("Wrong Case");
                    break;
            }
        }
    }

}
