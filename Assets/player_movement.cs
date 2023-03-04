using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = input.GetAxis("Horizontal");
        float moveVertical = input.GetAxis("Vertical");

        rb2d.velocity = new vector2(moveHorizontal * speed, moveVertical * speed);
    }
}
