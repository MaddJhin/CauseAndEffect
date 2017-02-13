#define bounceTest_no
using UnityEngine;
using System.Collections;

public class Ballista : MonoBehaviour {

    //public BallistaArrow arrow;
#if bounceTest
    public ArrowBounceTest arrow;
#elif (!bouncTest)
    public BallistaArrow arrow;
#endif

    public Sprite frame0;
    public Sprite frame1;
    public SpriteRenderer ballistaSprite;
    public bool hasFired = false;

    private Vector3 arrowPos;
    private SpriteRenderer arrowSprite;
    private bool flipped = false;
    private float direction = 1;

    private float clickTime;

    void Awake()
    {

#if bounceTest
        arrow = GetComponentInChildren<ArrowBounceTest>();
#elif (!bounceTest)
        arrow = GetComponentInChildren<BallistaArrow>();
#endif
        if (arrow != null)
            arrowSprite = arrow.GetComponent<SpriteRenderer>();
    }

    void OnEnable()
    {
        GameEventManager.GameLaunch += GameLaunch;
        GameEventManager.GameReset  += GameReset;
    }

    void OnDisable()
    {
        GameEventManager.GameReset -= GameLaunch;
        GameEventManager.GameReset -= GameReset;
    }

    void OnMouseDown()
    {
        clickTime = Time.time;
    }

    void OnMouseUp()
    {
        if (Time.time - clickTime < 0.35 && !GameManager.instance.inPlay)
        {
            Flip();
        }
    }

    public void FireArrow()
    {
        if(!hasFired)
        {
            hasFired = true;
            arrow.Shoot();
            ballistaSprite.sprite = frame1;
        }        
    }

    public void Flip()
    {
        Debug.Log("FLIPPED THE BITCH");
        if (flipped)
        {
            direction *= -1;
            Debug.Log("Flip: " + gameObject.transform.position);
            //gameObject.transform.Rotate(0f,180,0f);
            transform.rotation = new Quaternion(0f, 0f, 0f, 0f);
            arrowPos = arrow.transform.localPosition;
            arrow.Flip();
            flipped = false;
        }
        else if (!flipped)
        {
            direction *= -1;
            Debug.Log("Flip: " + gameObject.transform.position);
            //gameObject.transform.Rotate(0f,180,0f);
            transform.rotation = new Quaternion(0f, 180f, 0, 0);
            //arrow.Flip();
            arrowPos = arrow.transform.localPosition;
            flipped = true;
        }
    }

    public void GameLaunch()
    {
        if (!arrow)
            return;
        arrowPos = arrow.transform.localPosition;
        hasFired = false;
    }

    public void GameReset()
    {
        hasFired = false;
        ballistaSprite.sprite = frame0;

        arrow.transform.localPosition = arrowPos;
        arrowSprite.enabled = false;
        arrowSprite.flipX = false;
        arrowSprite.flipY = false;
    }
}
