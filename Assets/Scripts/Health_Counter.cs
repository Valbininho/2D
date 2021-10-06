using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEngine;

public class Health_Counter : MonoBehaviour
{

    public Image[] lives; //cree une liste/tableau des images en ui
    public int livesRemaining;

    public void Loselife()
    {
        livesRemaining--; //-1 au nombre de vies
        lives[livesRemaining].enabled = false; // cache un coeur

        if(livesRemaining == 0) //si on a plus de vie on perd
        {
            Debug.Log("Game Over");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Enemy"))
        {
            Loselife();
        }
    }
}
