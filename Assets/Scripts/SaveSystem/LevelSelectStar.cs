using UnityEngine;
using UnityEngine.UI;

public class LevelSelectStar : MonoBehaviour {

    private Image image;

    void Awake()
    {
        image = GetComponent<Image>();
    }

	// Use this for initialization
	public void SetStar (bool unlocked) {

        if (unlocked)
            image.color = Color.yellow;
        else
            image.color = Color.black;	
	}
}
