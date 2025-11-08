using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D _rigidbody2D;
    public int speed = 4;
    private SpriteRenderer _spriteRenderer;
    // Update is called once per frame

    private void Start ()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }


     private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");

        if (horizontal > 0) { _spriteRenderer.flipX = true; }
        else if (horizontal < 0) { _spriteRenderer.flipX = false; }
            
        _rigidbody2D.velocity = new Vector2(horizontal * speed, _rigidbody2D.velocity.y);



        

    }
}