using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEngine;

public class Health_Counter : MonoBehaviour
{

    public Image[] lives; //créé une liste/tableau des images en ui
    public int livesRemaining;

    public void Loselife()
    {
        if (/*Collider du joueur touche selui de l'enemi */)
        {
            livesRemaining--; //-1 au nombre de vies
            lives[livesRemaining].enabled = false; // cache un coeur
        }
        if(livesRemaining == 0) //si on a plus de vie on perd
        {
            Debug.Log("Game Over");
        }
    }

}
/* Notes
    [SerializeField] private float HealthPoint; /*sprite = <3 <3 <3
//anim 
private Animator heartAnimator;
private bool GetHit = false;


void Start()
{
    heartAnimator = GetComponent<Animator>();
}

private void Hit()
{
    // Hit = HealthPoint - 1;
}

private void OnCollisionEnter2D(/*Playercolider)
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