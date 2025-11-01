using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(xInput * multiplier, rb.velocity.y);






        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Sr.color = new Color(1, 0, 1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Sr.color = new Color(0, 1, 0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Sr.color = new Color((float)0.5, (float)0.3, (float)0.9);

        }
        /*
        if (Input.GetKeyDown(KeyCode.A))
        {
          
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            
            rb.velocity = new Vector2(xInput, rb.velocity.y);
            
            
        } */
    }
}
