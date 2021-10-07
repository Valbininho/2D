using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bob : MonoBehaviour
{
    private Rigidbody2D myRB; 
    private Vector2 stickDirection;
    private Animator myAnimator; 
    private SpriteRenderer mySpriteRenderer;

    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }


}
