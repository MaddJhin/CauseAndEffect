using UnityEngine;
using System.Collections;

public class BallistaArrow : MonoBehaviour
{
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
    private float dirrection = 1f;

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
    void Update()
    {
        timer += Time.deltaTime;
        origin = Vector3toVector2(gameObject.transform.position);
        RaycastHit2D hit = Physics2D.Raycast(gameObject.transform.position, gameObject.transform.right, 0.1f, layerMask);
        
        if (!hit)
        {
            UpdateAngle();
        }
        DeflectDraw();

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (bouncesLeft == 0)
        {
            TurnOff();
            return;
        }
        float debugFloat = (transform.rotation.eulerAngles.z + angle);
        Debug.Log("Old Rotation is: " + debugFloat);
        float zRotation = ClampRotation(transform.rotation.eulerAngles.z + (angle * dirrection));
        Debug.Log("New Z Roation is: " + zRotation);

        if (timer > 0.1f)
        {
            transform.eulerAngles = new Vector3(transform.rotation.eulerAngles.x,
                                                transform.rotation.eulerAngles.y,
                                                zRotation);
            body.velocity = Vector2.zero;
            body.AddForce(transform.right * speed);
            timer = 0;
        }

        bouncesLeft--;
        //Debug.Break();
        //CalculateBounce();
    }

    void UpdateAngle()
    {
        RaycastHit2D hit = Physics2D.Raycast(origin, gameObject.transform.right, 100f, layerMask);
        //Debug.DrawLine(origin, hit.point);

        //Debug.Log("Collision Spot is: " + hit.point);
        //Debug.Log("Object hit is: " + hit.transform.gameObject.name);
        //Debug.DrawLine(origin, hit.point);

        Vector3 dirrection = (hit.point - origin).normalized;
        Vector3 reflectedVector = Vector3.Reflect(dirrection, hit.normal);

        //Debug.DrawRay(hit.point, reflectedVector * 10);

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
        //body.velocity = new Vector2(transform.right.x, transform.right.y) * speed;
        body.AddForce(transform.right * speed);
    }

    public void Flip()
    {
        startPosition = transform.position;
        startRotation = transform.rotation;

        foreach (Transform trans in GetComponentsInChildren<Transform>(true))
        {
            trans.gameObject.layer = LayerMask.NameToLayer("Arrow");
        }
    }

    public void GameLaunch()
    {
        SetDirection();
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
        Vector2 testOrigin = Vector3toVector2(gameObject.transform.position);
        RaycastHit2D hit = Physics2D.Raycast(origin, gameObject.transform.right, 100f, layerMask);
        //Debug.Log("Layer hit is: " + LayerMask.LayerToName(layerMask));

        if (hit)
        {
            //Debug.Log("Collision Spot is: " + hit.point);
            Debug.Log("Object hit is: " + hit.transform.gameObject.name);
            Debug.DrawLine(origin, hit.point);
            Vector3 dirrection = (hit.point - testOrigin).normalized;
            Vector3 reflectedVector = Vector3.Reflect(dirrection, hit.normal);
            Debug.DrawRay(hit.point, reflectedVector * 10);
        }
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
        else if (angle < 0)
            return angle + 360;
        else
            return angle;
    }

    private void SetDirection()
    {
        Transform parent = GetComponentInParent<Ballista>().transform;
        if (parent.localRotation.eulerAngles.y == 0)
            dirrection = 1f;
        else
            dirrection = -1f;
    }
}
