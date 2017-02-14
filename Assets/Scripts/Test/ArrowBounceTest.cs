using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowBounceTest : MonoBehaviour {

    public float speed;
    public int bounces = 4;

    private SpriteRenderer sprite;
    private PolygonCollider2D col;
    private Rigidbody2D body;
    private Vector3 startPosition;
    private Quaternion startRotation;
    private int bouncesLeft;
    private float angle;
    private Vector2 origin;
    private float timer;
    private LayerMask layerMask;

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        col = GetComponent<PolygonCollider2D>();
    }

    void Start()
    {
        layerMask = (1 << 0)
                | (1 << 9)
                | (1 << 10)
                | (1 << 12);
        //layerMask = ~layerMask;
    }

    // Update is called once per frame
    void Update () {
        timer += Time.deltaTime;

        RaycastHit2D hit = Physics2D.Raycast(gameObject.transform.position, gameObject.transform.right, 0.5f, layerMask);
        Debug.Log(!hit);

        if (!hit)
        {
            UpdateAngle();
        }
        //DeflectDraw();

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (bouncesLeft == 0)
        {
            TurnOff();
            return;
        }

        float zRotation = ClampRotation(transform.rotation.eulerAngles.z + angle);
        Debug.Log("New Z Roation is: " + zRotation);

        if (timer > 0.1f)
        {
            transform.eulerAngles = new Vector3(transform.localRotation.eulerAngles.x,
                                                transform.localRotation.eulerAngles.y,
                                                zRotation);
            body.velocity = new Vector2(transform.right.x, transform.right.y) * speed;
            timer = 0;
        }

        bouncesLeft--;
        //Debug.Break();
        //CalculateBounce();
    }

    void UpdateAngle()
    {
        origin = Vector3toVector2(gameObject.transform.position);

        RaycastHit2D hit = Physics2D.Raycast(origin, gameObject.transform.right, 100f, layerMask);
        Debug.DrawLine(origin, hit.point);

        Debug.Log("Collision Spot is: " + hit.point);
        Debug.Log("Object hit is: " + hit.transform.gameObject.name);
        Debug.DrawLine(origin, hit.point);

        Vector3 dirrection = (hit.point - origin).normalized;
        Vector3 reflectedVector = Vector3.Reflect(dirrection, hit.normal);

        Debug.DrawRay(hit.point, reflectedVector * 10);

        Vector3 firstVector = Vector2toVector3(hit.point) - gameObject.transform.position;

        angle = AngleBetweenVector3(firstVector, reflectedVector);
    }

    public void TurnOff()
    {
        sprite.enabled = false;
        body.velocity = Vector2.zero;
        body.angularVelocity = 0f;
        col.enabled = false;
        transform.position = startPosition;
        transform.rotation = startRotation;
    }

    public void Shoot()
    {
        bouncesLeft = bounces;
        sprite.enabled = true;
        col.enabled = true;
        body.velocity = new Vector2(transform.right.x, transform.right.y) * speed;
    }

    public void Flip()
    {
        startPosition = transform.position;
        startRotation = transform.rotation;

        layerMask = (1 << 0)
        | (1 << 9)
        | (1 << 10)
        | (1 << 12);
    }

    public void GameLaunch()
    {
        startPosition = transform.position;
        startRotation = transform.rotation;
    }

    public void GameReset()
    {
        TurnOff();
    }

    void OnEnable()
    {
        GameEventManager.GameLaunch += GameLaunch;
        GameEventManager.GameReset += GameReset;
    }

    void OnDisable()
    {
        GameEventManager.GameLaunch -= GameLaunch;
        GameEventManager.GameReset -= GameReset;
    }

    void DeflectDraw()
    {
        origin = Vector3toVector2(gameObject.transform.position);
        RaycastHit2D hit = Physics2D.Raycast(origin, gameObject.transform.right, 100f, layerMask);
        //Debug.Log("Layer hit is: " + LayerMask.LayerToName(layerMask));
        Debug.Log("Collision Spot is: " + hit.point);
        Debug.Log("Object hit is: " + hit.transform.gameObject.name);
        Debug.DrawLine(origin, hit.point); 

        Vector3 dirrection = (hit.point - origin).normalized;
        Vector3 reflectedVector = Vector3.Reflect(dirrection, hit.normal);

        Debug.DrawRay(hit.point, reflectedVector * 10);
    }
    
    private float AngleBetweenVector2(Vector2 vec1, Vector2 vec2)
    {
        Vector2 diference = vec2 - vec1;
        float sign = (vec2.y < vec1.y) ? -1.0f : 1.0f;
        return Vector2.Angle(Vector2.right, diference) * sign;
    }

    private float AngleBetweenVector3(Vector3 vec1, Vector3 vec2)
    {
        float angle = Vector3.Angle(vec1, vec2);
        Vector3 cross = Vector3.Cross(vec1, vec2);
        if (cross.z < 0)
            angle = -angle;
        return angle;
    }

    private Vector2 Vector3toVector2(Vector3 vector)
    {
        Vector2 newVector = new Vector2(vector.x, vector.y);
        return newVector;
    }

    private Vector3 Vector2toVector3(Vector2 vector)
    {
        Vector3 newVector = new Vector3(vector.x, vector.y, 0f);
        return newVector;
    }

    private float ClampRotation(float angle)
    {
        if (angle > 360)
            return angle - 360;
        else
            return angle;
    }
}
