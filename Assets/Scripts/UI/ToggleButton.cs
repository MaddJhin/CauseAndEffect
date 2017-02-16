using UnityEngine.UI;
using UnityEngine;

public class ToggleButton : MonoBehaviour {

    private Button currentButton;

    public void BeenClicked(Button newButton)
    {
        if (currentButton != null)
            currentButton.image.color = Color.white;

        newButton.image.color = Color.black;
        currentButton = newButton;
    }
}
