using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeoController : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Hit");
    }
    private Rigidbody2D rb;
    public int multiplier = 5;
    // Start is called before the first frame update
     void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
     void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(xInput * multiplier, rb.velocity.y);
        
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
  
