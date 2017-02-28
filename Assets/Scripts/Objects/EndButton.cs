using UnityEngine;
using UnityEngine.SceneManagement;

public class EndButton : MonoBehaviour {

    public int timesHit = 1;

    private int amountHit = 0;

    private AudioSource audio;
    //private UIManager guiManager;

    void Awake()
    {
        audio = GetComponent<AudioSource>();
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
            if (amountHit == timesHit)
            {
                string levelName = SceneManager.GetActiveScene().name;
                //SaveSwitch.UpdateStars(levelName, 0);
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
    }

    void OnEnable()
    {
        GameEventManager.GameReset += GameReset;
    }

    void OnDisable()
    {
        GameEventManager.GameReset -= GameReset;
    }
}