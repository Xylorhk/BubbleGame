using UnityEngine;
using UnityEngine.UI;

public class MonsterEvent : MonoBehaviour
{
    public GameObject EventArea1;
    public GameObject EventArea2;
    public GameObject EventArea3;
    public GameObject EventArea4;
    public GameObject EventArea5;
    public GameObject EventArea6;
    public GameObject EventArea7;
    public GameObject Spawn;

    Vector3 EventPos;
    float EventTimer;
    int MonsterLocation;
    bool EventActive;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        EventTimer = 30;
    }

    // Update is called once per frame
    void Update()
    {
        EventTimer -= Time.deltaTime;

        if (EventTimer < 1)
        {
            EventActive = true;
            MonsterLocation = Random.Range(1, 7);
            if (MonsterLocation == 1)
            {
                EventPos = EventArea1.transform.position;
                Instantiate(Spawn, EventPos, Quaternion.identity);
            }
            else if (MonsterLocation == 2)
            {
                EventPos = EventArea2.transform.position;
                Instantiate(Spawn, EventPos, Quaternion.identity);
            }
            else if (MonsterLocation == 3)
            {
                EventPos = EventArea3.transform.position;
                Instantiate(Spawn, EventPos, Quaternion.identity);
            }
            else if (MonsterLocation == 4)
            {
                EventPos = EventArea4.transform.position;
                Instantiate(Spawn, EventPos, Quaternion.identity);
            }
            else if (MonsterLocation == 5)
            {
                EventPos = EventArea5.transform.position;
                Instantiate(Spawn, EventPos, Quaternion.identity);
            }
            else if (MonsterLocation == 6)
            {
                EventPos = EventArea6.transform.position;
                Instantiate(Spawn, EventPos, Quaternion.identity);
            }
            else if (MonsterLocation == 7)
            {
                EventPos = EventArea7.transform.position;
                Instantiate(Spawn, EventPos, Quaternion.identity);
            }
        }
    }
}