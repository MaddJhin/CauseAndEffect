using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileCamera : MonoBehaviour
{
    public SpriteRenderer background;
    public int width, height;
    public float speed;
    public float maxOrtho = 12.5f;

    private Camera cam;
    private Vector2 currentTouchVector;
    private float currentOrtho;
    private float currentTouchDistance;
    private Vector2?[] touchPositions = {
        null,
        null
    };

    private float clampX,clampY;

    void Awake()
    {
        cam = GetComponent<Camera>();
        background = GameObject.FindGameObjectWithTag("Background").GetComponent<SpriteRenderer>();
    }

    // Use this for initialization
    void Start()
    {
        // Set screen resolution
        Screen.SetResolution(width, height, true);
    }

    // Update is called once per frame
    void Update()
    {
        // Update Clamp Values
        UpdateClampValues();

        if (GameManager.instance.dragging)
            return;
        
        // If there is no touch press
        if (Input.touchCount == 0)
        {
            // Reset all counts 
            touchPositions[0] = null;
            touchPositions[1] = null;
        }

        // If there is one button press
        if (Input.touchCount == 1)
        {
            // Was there wasn't a previous one touch
            if (touchPositions[0] == null)
            {
                touchPositions[0] = Input.GetTouch(0).position;
            }
            //else
            //{
            // Detect Current Position
            //Vector2 currentTouchPosition = Input.GetTouch(0).position;

            // Get the delta position
            Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
            //float speed = touchDeltaPosition.magnitude / Time.deltaTime;

            // Move object across XY plane
            ClampMove(touchDeltaPosition);

            //transform.position += transform.TransformDirection((Vector3)
            //    (touchPositions[0] - currentTouchPosition) * cam.orthographicSize / cam.pixelHeight * 2f);
            //}
        }

        // If there are two button presses
        if (Input.touchCount == 2)
        {
            // If there was no previous double touch
            if (touchPositions[1] == null)
            {
                // get the new positions and distance
                touchPositions[0] = Input.GetTouch(0).position;
                touchPositions[1] = Input.GetTouch(1).position;
                currentTouchVector = (Vector2)(touchPositions[0] - touchPositions[1]);
                currentTouchDistance = currentTouchVector.magnitude;
            }

            Vector2[] newTouchPositions = {
                    Input.GetTouch(0).position,
                    Input.GetTouch(1).position
                };

            // Get delta position and move
            Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
            //transform.Translate(-touchDeltaPosition.x * Time.deltaTime * speed, -touchDeltaPosition.y * Time.deltaTime * speed, 0);
            ClampMove(touchDeltaPosition);

            // Get the difference touch vector
            Vector2 newTouchVector = newTouchPositions[0] - newTouchPositions[1];
            float newTouchDistance = newTouchVector.magnitude;

            cam.orthographicSize *= currentTouchDistance / newTouchDistance;
            cam.orthographicSize = Mathf.Clamp(cam.orthographicSize, 3f, maxOrtho);

            touchPositions[0] = newTouchPositions[0];
            touchPositions[1] = newTouchPositions[1];
            currentTouchVector = newTouchVector;
            currentTouchDistance = newTouchDistance;
        }
    }

    void ClampMove(Vector2 moveDelta)
    {
        transform.Translate(-moveDelta.x * Time.deltaTime * speed, 
                            -moveDelta.y * Time.deltaTime * speed, 
                            0);

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -clampX, clampX), 
                                         Mathf.Clamp(transform.position.y, -clampY, clampY), 
                                         transform.position.z);
    }

    void UpdateClampValues()
    {
        clampY = ((background.bounds.size.y / 2) - cam.orthographicSize - 0.3f);
        clampX = ((background.bounds.size.x / 2) - (cam.orthographicSize * cam.aspect) - 0.3f);
    }
}