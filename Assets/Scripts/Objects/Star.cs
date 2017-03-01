using UnityEngine;
using UnityEngine.SceneManagement;

public class Star : MonoBehaviour {

    [Range(1,2)]
    public int starIndex;

    public bool unlocked = false;

    //private void Start()
    //{
    //    if (starIndex == 1)
    //        StarManager.instance.star1 = this;
    //    else if (starIndex == 2)
    //        StarManager.instance.star2 = this;
    //}

    void OnEnable()
    {
        //GameEventManager.GameLaunch += GameLaunch;
        GameEventManager.GameReset += GameReset;
        GameEventManager.LevelComplete += LevelComplete;
    }

    void OnDisable()
    {
        //GameEventManager.GameReset -= GameLaunch;
        GameEventManager.GameReset -= GameReset;
        GameEventManager.LevelComplete -= LevelComplete;
    }

    public void GameReset()
    {
        this.gameObject.GetComponent<SpriteRenderer>().enabled = true;
        unlocked = false;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Block" || other.gameObject.tag == "Bolt" || 
           other.gameObject.tag == "CatapultBall" || other.gameObject.tag == "StartBlock")
        {
            this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
            unlocked = true;
        }
    }

    void LevelComplete()
    {
        if (unlocked)
        {
            string levelName = SceneManager.GetActiveScene().name;
            SaveSwitch.UpdateStars(levelName, starIndex);
        }
    }

    //void UnlockStar()
    //{
    //    string levelName = SceneManager.GetActiveScene().name;

    //    SaveLoadData level = (SaveLoadData)SaveLoadManagement.m_current.GetType().GetField(levelName).GetValue(SaveLoadManagement.m_current);

    //    if(starIndex == 1)
    //    {
    //        level.m_star2 = true;
    //    }
    //    else if (starIndex == 2)
    //    {
    //        level.m_star3 = true;
    //    }
    //}
}
