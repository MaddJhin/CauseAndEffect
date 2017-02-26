using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelectButton : MonoBehaviour {

    public bool unlocked, Star_One, Star_Two, Star_Three;
    public Sprite unlockedSprite, lockedSprite;
    public LevelSelectStar star1, star2, star3;
    public Text text;

    private Image image;
    private Button button;

    private void Awake()
    {
        SetStars();
        image = GetComponent<Image>();
        button = GetComponent<Button>();
    }

    private void Start()
    {
        star1.SetStar(Star_One);
        star2.SetStar(Star_Two);
        star3.SetStar(Star_Three);

        SetImage();        
    }

    void SetStars()
    {
        foreach (Transform child in transform)
        {
            if (child.name == "Star_One")
            {
                star1 = child.GetComponent<LevelSelectStar>();
            }
            else if (child.name == "Star_Two")
            {
                star2 = child.GetComponent<LevelSelectStar>();
            }
            else if (child.name == "Star_Three")
            {
                star3 = child.GetComponent<LevelSelectStar>();
            }
            else if(child.name == "Text")
            {
                text = child.GetComponent<Text>();
            }
        }
    }

    void SetImage()
    {
        if (unlocked)
        {
            image.sprite = unlockedSprite;
            text.enabled = true;
            button.interactable = true;
        }
        else
        {
            image.sprite = lockedSprite;
            text.enabled = false;
            button.interactable = false;
        }
    }
}
