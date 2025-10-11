using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GeoController : MonoBehaviour
{
    public string Level2 = "Scene_2";
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Hit");

        switch (collision.tag)
        {
            case "Death":
                {
                    string thisLevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thisLevel);
                    break;
                }
            case "Finish":
                {
                    SceneManager.LoadScene(Level2);
                    break;
                }

        }
    }

  

    private Rigidbody2D rb;
    public int multiplier = 5;
    public int jumpmult = 10;
    // Start is called before the first frame update
     void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
     void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(xInput * multiplier, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(xInput, yInput * jumpmult);
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
  
