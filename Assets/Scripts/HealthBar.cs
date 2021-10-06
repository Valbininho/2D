using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour
{
    int Hit;

    [SerializeField] private int HealthPoint; /*sprite = <3 <3 <3*/
    //anim 
    private Animator heartAnimator;
    private bool GetHit= false;


    void Start()
    {
        heartAnimator = GetComponent<Animator>();
    }

    private void OnHit()
    {
        Hit = HealthPoint - 1;
    }

    private void OnCollisionEnter2D(/*Playercolider*/)
    {
        
    }

    void Update()
    {
        
    }
}
/* si player collides w/ enemy alors HealthPoint -1 --> anim sprite = <3 <3
 * si HealthPoint down to 0 player dead --> anim ded
 * 
 * 
 * if playerCollider collison w/ enemyCollider set bool getHit = true
 *      healthPoint - 1
 * 
 * */