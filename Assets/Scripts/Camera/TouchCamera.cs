// Just add this script to your camera. It doesn't need any configuration.

using UnityEngine;

public class TouchCamera : MonoBehaviour {

    public SpriteRenderer background;
    public int height;
    public int width;
    public float minOrtho = 1.0f;
    public float maxOrtho = 12.5f;

    Vector2?[] oldTouchPositions = {
		null,
		null
	};
	Vector2 oldTouchVector;
	float oldTouchDistance;
    Camera cam;
    private Vector3 target = Vector3.zero;
    private float targetOrtho;

    void Awake()
    {
        cam = GetComponent<Camera>();
        targetOrtho = Camera.main.orthographicSize;
        background = GameObject.FindGameObjectWithTag("Background").GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        Screen.SetResolution(width, height, true);
    }

    void Update() {

        if (GameManager.instance.dragging == true)
        {
            oldTouchPositions[0] = null;
            oldTouchPositions[1] = null;
            return;
        }

        if (Input.touchCount == 0) {
			oldTouchPositions[0] = null;
			oldTouchPositions[1] = null;
		}
		else if (Input.touchCount == 1) {
			if (oldTouchPositions[0] == null || oldTouchPositions[1] != null) {
				oldTouchPositions[0] = Input.GetTouch(0).position;
				oldTouchPositions[1] = null;
			}
			else {
				Vector2 newTouchPosition = Input.GetTouch(0).position;
				
				target += transform.TransformDirection((Vector3)((oldTouchPositions[0] - newTouchPosition) * cam.orthographicSize / cam.pixelHeight * 2f));

                float clampY = ((background.bounds.size.y / 2) - targetOrtho - 0.3f);
                float clampX = ((background.bounds.size.x / 2) - (targetOrtho * cam.aspect) - 0.3f);

                Vector3 targetPos = new Vector3(Mathf.Clamp(target.x, -clampX, clampX), Mathf.Clamp(target.y, clampY * -1, clampY), transform.position.z);
                transform.position = targetPos;

                oldTouchPositions[0] = newTouchPosition;
			}
		}
		else {
			if (oldTouchPositions[1] == null) {
				oldTouchPositions[0] = Input.GetTouch(0).position;
				oldTouchPositions[1] = Input.GetTouch(1).position;
				oldTouchVector = (Vector2)(oldTouchPositions[0] - oldTouchPositions[1]);
				oldTouchDistance = oldTouchVector.magnitude;
			}
			else {
				Vector2 screen = new Vector2(cam.pixelWidth, cam.pixelHeight);
				
				Vector2[] newTouchPositions = {
					Input.GetTouch(0).position,
					Input.GetTouch(1).position
				};
				Vector2 newTouchVector = newTouchPositions[0] - newTouchPositions[1];
				float newTouchDistance = newTouchVector.magnitude;

                //transform.position += transform.TransformDirection((Vector3)((oldTouchPositions[0] + oldTouchPositions[1] - screen) * cam.orthographicSize / screen.y));
                //transform.localRotation *= Quaternion.Euler(new Vector3(0, 0, Mathf.Asin(Mathf.Clamp((oldTouchVector.y * newTouchVector.x - oldTouchVector.x * newTouchVector.y) / oldTouchDistance / newTouchDistance, -1f, 1f)) / 0.0174532924f));
                //target += transform.TransformDirection((Vector3)((oldTouchPositions[0] + oldTouchPositions[1] - screen) * cam.orthographicSize / screen.y));

                //float clampY = ((background.bounds.size.y / 2) - targetOrtho - 0.3f);
                //float clampX = ((background.bounds.size.x / 2) - (targetOrtho * cam.aspect) - 0.3f);

                //Vector3 targetPos = new Vector3(Mathf.Clamp(target.x, -clampX, clampX), Mathf.Clamp(target.y, clampY * -1, clampY), transform.position.z);
                //transform.position = targetPos;


                targetOrtho *= oldTouchDistance / newTouchDistance;
                targetOrtho = Mathf.Clamp(targetOrtho, minOrtho, maxOrtho);
                cam.orthographicSize = targetOrtho;

				//transform.position -= transform.TransformDirection((newTouchPositions[0] + newTouchPositions[1] - screen) * cam.orthographicSize / screen.y);

				oldTouchPositions[0] = newTouchPositions[0];
				oldTouchPositions[1] = newTouchPositions[1];
				oldTouchVector = newTouchVector;
				oldTouchDistance = newTouchDistance;
			}
		}
	}
}
