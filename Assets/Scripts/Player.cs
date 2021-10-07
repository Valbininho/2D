using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Player : MonoBehaviour
{
    public float speed = 3f;
    Rigidbody2D rb;
    Vector2 dir;
    public Animator animator;
    private SpriteRenderer mySpriteRenderer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }
   
    void Update()
    {
        dir.x = Input.GetAxisRaw("Horizontal");
        dir.y = Input.GetAxisRaw("Vertical");
        rb.MovePosition(rb.position + dir * speed * Time.fixedDeltaTime);

        animator.SetFloat("stickXpose", dir.x);
        animator.SetFloat("stickYpose", dir.y);
        animator.SetFloat("Speed", dir.sqrMagnitude);

    }

    public void onmov(InputAction.CallbackContext imput)
    {
        Debug.Log(imput.ReadValue<Vector2>());
    }
}
