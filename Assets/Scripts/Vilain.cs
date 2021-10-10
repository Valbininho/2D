using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Vilain : MonoBehaviour
{
    public float speed;
    public Transform target;
    private bool damageGiven;

    void Start()
    {
        GameObject.Find("Loselife()").GetComponent<Health_Counter>();
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        damageGiven = true;

        Debug.Log(col.gameObject.name);

        if (GameObject.Find("timerEnded").GetComponent<Timer>());
        {
            if (damageGiven == true) ;
                /*livesRemaining--;*/
        }
    }
}