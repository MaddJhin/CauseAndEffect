﻿using UnityEngine;
using System.Collections;

public class CameraControls : MonoBehaviour
{

    public float zoomSpeed = 1;
    public float targetOrtho;
    public float smoothSpeed = 2.0f;
    public float minOrtho = 1.0f;
    public float maxOrtho = 20.0f;

    public float panSpeed = 3f;

    public SpriteRenderer background;

    public float mapX = 61.4f;
    public float mapY = 41.4f;
    private float minX;
    private float maxX;
    private float minY;
    private float maxY;

    private float vertExtent;
    private float horzExtent;

    private Camera cam;
    private GameManager manager;
    private Vector3 target;
    private float clampX, clampY;

    void Start()
    {
        targetOrtho = Camera.main.orthographicSize;
        cam = GetComponent<Camera>();
        manager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
        background = GameObject.FindGameObjectWithTag("Background").GetComponent<SpriteRenderer>();
    }

#if UNITY_EDITOR

    void Update()
    {
        //Debug.Log(Camera.main.ViewportToWorldPoint(new Vector2(1,1)));


        if (manager.dragging)
            return;

        clampY = ((background.bounds.size.y / 2) - targetOrtho - 0.3f);
        clampX = ((background.bounds.size.x / 2) - (targetOrtho * cam.aspect) - 0.3f);
        //Debug.Log(clampY);


        if (Input.GetMouseButton(0))
        {
            target += new Vector3(Input.GetAxisRaw("Mouse X") * Time.deltaTime * panSpeed * -1f, Input.GetAxisRaw("Mouse Y") * Time.deltaTime * panSpeed * -1f, 0f);
        }

        //if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        //{
        //    // Get movement of the finger since last frame
        //    Vector3 touchDeltaPosition = Input.GetTouch(0).position;

        //    // Move object across XY plane
        //    target += new Vector3(-touchDeltaPosition.x * panSpeed, -touchDeltaPosition.y * panSpeed, 0);
        //}


        Vector3 targetPos = new Vector3(Mathf.Clamp(target.x, -clampX, clampX), Mathf.Clamp(target.y, clampY * -1, clampY), transform.position.z);

        float scroll = Input.GetAxis("Mouse ScrollWheel");
        if (scroll != 0.0f)
        {
            targetOrtho -= scroll * zoomSpeed;
            targetOrtho = Mathf.Clamp(targetOrtho, minOrtho, maxOrtho);
        }

        Camera.main.orthographicSize = Mathf.MoveTowards(Camera.main.orthographicSize, targetOrtho, panSpeed * Time.deltaTime);
        transform.position = targetPos; //Vector3.MoveTowards(transform.position, targetPos, panSpeed * Time.deltaTime);   
    }

#endif

}