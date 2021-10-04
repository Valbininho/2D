using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour
{
    [SerializeField] private float HealthPoint; /*sprite = <3 <3 <3*/

    void Start()
    {

    }

    private void Hit()
    {
        HealthPoint = - 1;
    }

    private void OnTriggerEnter(/*Playercolider*/)
    {
        
    }

    void Update()
    {
        
    }
}
/* si player collides w/ enemy alors HealthPoint -1 --> anim sprite = <3 <3
 * si HealthPoint down to 0 player dead --> anim ded
 * 