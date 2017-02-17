using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileCamera : MonoBehaviour {

    public int width, height;

    Vector2?[] oldTouchPositions = {
        null,
        null
    };

    // Use this for initialization
    void Start ()
    {
        // Set screen resolution
        Screen.SetResolution(width, height, true);
	}
	
	// Update is called once per frame
	void Update () {
	

        // If there is no touch press
        if (Input.touchCount == 0)
        {
            // Reset all counts 
            oldTouchPositions[0] = null;
            oldTouchPositions[1] = null;
        }

        // If there is one button press
        
        	
	}
}
