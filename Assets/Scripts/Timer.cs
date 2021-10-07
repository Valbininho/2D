using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float hitTime = 2.5f;
    private bool vilain2;


    void Start()
    {
        vilain2 = GetComponent<Vilain>();
        
    }


    void Update()
    {
        hitTime -= Time.deltaTime;

        if (hitTime <= 0.0f)
        {
            timerEnded();
        }
    }


    void timerEnded()
    {
        
    }
}