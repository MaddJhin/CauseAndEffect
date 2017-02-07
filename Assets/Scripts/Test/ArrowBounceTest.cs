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
    private Vector3 bounceVector;
    private Vector3 dirrection;

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        col = GetComponent<PolygonCollider2D>();
    }

    // Update is called once per frame
    void Update () {

        RaycastHit2D hit = Physics2D.Raycast(gameObject.transform.position, gameObject.transform.right, 1000f, 1);
        DeflectDraw(hit);

        Debug.DrawLine(gameObject.transform.position, hit.point);
        UpdateAngle();

        if (hit)
        {
                        
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (bouncesLeft == 0)
        {
            TurnOff();
            return;
        }

        //transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        Quaternion lookRotation = Quaternion.LookRotation(dirrection, Vector3.forward);
        transform.rotation = lookRotation;
        Debug.Log("Angle between teh angle on hit is: " + angle);

        body.velocity = new Vector2(transform.right.x, transform.right.y) * speed;


        bouncesLeft--;
        //CalculateBounce();
    }

    void UpdateAngle()
    {
        RaycastHit2D hit = Physics2D.Raycast(gameObject.transform.position, gameObject.transform.right, 1000f, 1);
        Vector2 firstVector = hit.point - Vector3toVector2(gameObject.transform.position);

        RaycastHit2D hit2 = Physics2D.Raycast(hit.point, hit.point.normalized, Mathf.Infinity, 1);
        Vector2 origin = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y);
        dirrection = (hit.point - origin).normalized;

        Vector3 reflectedVector = Vector3.Reflect(dirrection, hit.normal);
        Vector2 secondVector = Vector3toVector2(reflectedVector);

        angle = AngleBetweenVector2(firstVector, secondVector);

        Debug.Log("Reflected Vector is: " + reflectedVector);   
        Debug.Log("Angle between Vetor 2 is: " + angle);

        bounceVector = reflectedVector;
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

    void DeflectDraw(RaycastHit2D hit)
    {
        RaycastHit2D hit2 = Physics2D.Raycast(hit.point, hit.point.normalized, Mathf.Infinity, 1);

        Vector2 origin = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y);
        Vector3 dirrection = (hit.point - origin).normalized;

        Vector3 reflectedVector = Vector3.Reflect(dirrection, hit.normal);

        //Debug.DrawLine(hit.point, reflectedVector * 1000);

        Debug.DrawRay(hit.point, reflectedVector);

        if (hit2)
        {
            
        }
        else
        {
            Debug.DrawLine(gameObject.transform.position, gameObject.transform.right * 1000);
        }
    }
    
    private float AngleBetweenVector2(Vector2 vec1, Vector2 vec2)
    {
        Vector2 diference = vec2 - vec1;
        float sign = (vec2.y < vec1.y) ? -1.0f : 1.0f;
        return Vector2.Angle(Vector2.right, diference) * sign;
    }

    private Vector2 Vector3toVector2(Vector3 vector)
    {
        Vector2 newVector = new Vector2(vector.x, vector.y);
        return newVector;
    }
}
