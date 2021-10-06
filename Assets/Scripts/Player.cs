using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Player : MonoBehaviour
{
    public float speed = 3f;
    Rigidbody2D rb;
    Vector2 dir;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
   
    void Update()
    {
        dir.x = Input.GetAxisRaw("Horizontal");
        dir.y = Input.GetAxisRaw("Vertical");
        rb.MovePosition(rb.position + dir * speed * Time.fixedDeltaTime);
    }

    public void onmov(InputAction.CallbackContext imput)
    {
        Debug.Log(imput.ReadValue<Vector2>());
    }
}
