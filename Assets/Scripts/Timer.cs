using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{

    [SerializeField] private float seconde;

    public float hitTimer = 2.5f;
    private bool timeHit;


    void Start()
    {
        /* vilain2 = GetComponent<Vilain>();*/
        GameObject.Find("OnTriggerEnter2D(Collider2D col)").GetComponent<Vilain>() ;
    }


    void Update()
    {
        if (timeHit == false)

            hitTimer -= Time.deltaTime;

        if (hitTimer <= 0.0f)
        {
            timerEnded();
        }
        if (hitTimer >= 0.0f);
    }


    void timerEnded()
    {
        if (timeHit == true)
            if (
    }
}