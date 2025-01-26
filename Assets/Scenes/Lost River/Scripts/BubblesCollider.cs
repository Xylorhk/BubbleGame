using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BubbleScript : MonoBehaviour
{
    public GameObject Monster;
    public GameObject Bubbles;
    Vector3 BubblePos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update ()
    {
    
    }
    void Attack ()
    {
        BubblePos.y = -10;
        MonsterEvent.EventActive = true;
        Instantiate(Monster, BubblePos, Quaternion.identity);
    }
    void Retreat ()
    {
        MonsterEvent.EventActive = false;
        //MonsterEvent.EventTimer = 15;
    }
}
