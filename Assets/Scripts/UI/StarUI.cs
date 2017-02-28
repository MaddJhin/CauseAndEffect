using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarUI : MonoBehaviour {

    [Range(1,2)]
    public int starIndex;

    private Image starImg;
    private Star star;

    void Awake()
    {
        starImg = GetComponent<Image>();

    }

    // Use this for initialization
    void Start ()
    {
        GetStar();
    }

    void Update()
    {
        if (star.unlocked == true)
            starImg.color = Color.white;
        else
            starImg.color = Color.black;
    }
	
    void GetStar()
    {
        Star[] tempStars = FindObjectsOfType<Star>();
        Debug.Log("There are " + tempStars.Length + " temp stars");
        foreach (Star tempStar in tempStars)
        {
            Debug.Log("Looking for star");
            if (tempStar.starIndex == starIndex)
            {
                Debug.Log("Found star");
                star = tempStar;
            }
        }
    }
}
