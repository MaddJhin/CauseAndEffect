﻿using UnityEngine;

public class EndButton : MonoBehaviour {

    public int timesHit = 1;

    private int amountHit = 0;

    private AudioSource hitSound;
    //private UIManager guiManager;

    void Awake()
    {
        hitSound = GetComponent<AudioSource>();
    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        if(collider.gameObject.tag == "Block" || collider.gameObject.tag == "CatapultBall" || collider.gameObject.tag == "Bolt")
        {
            DumpThing(collider.gameObject);
            amountHit++;
            if (amountHit == timesHit)
            {
                hitSound.Play();
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