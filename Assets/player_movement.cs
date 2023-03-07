using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    public float speed;
    public float jump;
    private Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D> ();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            rb2d.velocity += Vector2.up * jump;
        }
        if(Input.GetKeyDown(KeyCode.A) == true)
        {
            rb2d.velocity = Vector2.left * speed;
        }
        if(Input.GetKeyDown(KeyCode.D) == true)
        {
            rb2d.velocity = Vector2.right * speed;
        }
    }
}
