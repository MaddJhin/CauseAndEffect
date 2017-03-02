using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndButton : MonoBehaviour {

    public int timesHit = 1;
    public Text count;

    private int amountHit = 0;

    private AudioSource audio;
    //private UIManager guiManager;

    void Awake()
    {
        audio = GetComponent<AudioSource>();
    }

    void Start()
    {
        if(SceneManager.GetActiveScene() != null)
            SaveSwitch.UpdateLatestLevel(SceneManager.GetActiveScene().buildIndex);

        count.text = timesHit.ToString();
    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        if(collider.gameObject.tag == "Block" || 
            collider.gameObject.tag == "CatapultBall" || 
            collider.gameObject.tag == "Bolt" ||
            collider.gameObject.tag == "TriggerObject")
        {
            audio.Play();
            DumpThing(collider.gameObject);
            amountHit++;
            ReduceCount();
            if (amountHit == timesHit)
            {
                string levelName = SceneManager.GetActiveScene().name;
                SaveSwitch.UpdateStars(levelName, 0);
                Debug.Log("Level name passed: " + levelName);
                GameEventManager.TriggerLevelComplete();
            }
        }
    }

    void DumpThing(GameObject thing)
    {
        GameObject dumpPoint = GameObject.FindGameObjectWithTag("Bucket");
        if (dumpPoint != null)
            thing.transform.position = dumpPoint.transform.position;
        else
            Debug.Log("Error: No Bucket Found");
    }

    void GameReset()
    {
        amountHit = 0;
        count.text = timesHit.ToString();
    }

    void OnEnable()
    {
        GameEventManager.GameReset += GameReset;
    }

    void OnDisable()
    {
        GameEventManager.GameReset -= GameReset;
    }

    void ReduceCount()
    {
        int hitsLeft = timesHit - amountHit;
        count.text = hitsLeft.ToString();
    }
}