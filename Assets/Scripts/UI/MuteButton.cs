using UnityEngine.UI;
using UnityEngine;

public class MuteButton : MonoBehaviour {

    public Sprite mutedSprite;
    public Sprite unmutedSprite;

    private Image spriteRen;
    private bool is_muted = false;

	// Use this for initialization
	void Start () {
        is_muted = AudioListener.pause;
        spriteRen = GetComponent<Image>();
        SetButton();
    }

    public void Button_Mute()
    {
        is_muted = !is_muted;
        AudioListener.pause = !AudioListener.pause;
        SetButton();
    }

    void SetButton()
    {
        if (is_muted)
            spriteRen.sprite = mutedSprite;
        else
            spriteRen.sprite = unmutedSprite;
    }
}
