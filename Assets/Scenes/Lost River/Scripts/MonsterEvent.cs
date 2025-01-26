using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class MonsterEvent : MonoBehaviour
{
    public GameObject EventArea1;
    public GameObject EventArea2;
    public GameObject EventArea3;
    public GameObject EventArea4;
    public GameObject EventArea5;
    public GameObject EventArea6;
    public GameObject EventArea7;
    public GameObject BubbleSpawn;
    public GameObject TheMonster;
    public GameObject Boat;
    Vector3 EventPos;
    Vector3 BoatPos;
    [SerializeField]
    public static float EventTimer;
    public float EventTime;
    public int MonsterLocation;
    public static bool EventActive;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        BoatPos = Boat.transform.position;
        EventPos = BoatPos;
        EventPos.y = -50;
        Instantiate(TheMonster, EventPos, Quaternion.identity, Boat.transform);
        EventTimer = EventTime;
        EventActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (EventActive == false)
        {
            EventTimer -= Time.deltaTime;
        }
        
        if (EventTimer < 1)
        {
            EventActive = true;
            EventTimer = 1;

            MonsterLocation = Random.Range(1, 7);
            if (MonsterLocation == 1)
            {
                EventPos = EventArea1.transform.position;
                Instantiate(BubbleSpawn, EventPos, Quaternion.identity, EventArea1.transform);
            }
            else if (MonsterLocation == 2)
            {
                EventPos = EventArea2.transform.position;
                Instantiate(BubbleSpawn, EventPos, Quaternion.identity, EventArea2.transform);
            }
            else if (MonsterLocation == 3)
            {
                EventPos = EventArea3.transform.position;
                Instantiate(BubbleSpawn, EventPos, Quaternion.identity, EventArea3.transform);
            }
            else if (MonsterLocation == 4)
            {
                EventPos = EventArea4.transform.position;
                Instantiate(BubbleSpawn, EventPos, Quaternion.identity, EventArea4.transform);
            }
            else if (MonsterLocation == 5)
            {
                EventPos = EventArea5.transform.position;
                Instantiate(BubbleSpawn, EventPos, Quaternion.identity, EventArea5.transform);
            }
            else if (MonsterLocation == 6)
            {
                EventPos = EventArea6.transform.position;
                Instantiate(BubbleSpawn, EventPos, Quaternion.identity, EventArea6.transform);
            }
            else if (MonsterLocation == 7)
            {
                EventPos = EventArea7.transform.position;
                Instantiate(BubbleSpawn, EventPos, Quaternion.identity, EventArea7.transform);
            }
        }
    }
}