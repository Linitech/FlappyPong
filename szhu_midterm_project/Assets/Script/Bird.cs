using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Bird : MonoBehaviour
{
    private float direction = 1;

    bool goingUp;
    bool goingDown;

    private Rigidbody2D rb2d;

    public bool xMove = true;
    private float speed;

    public float Border { get; private set; }


    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>(); //declare value of the variable
    }

    // Update is called once per frame
    void Update()
    {

        //var velocity = rb2d.velocity; //creates and declare variables for velocity

        if (Input.GetKey(KeyCode.W))
        {
            rb2d.AddForce(Vector2.up * direction);
        }

        if (xMove == true)
        {
            transform.position = new Vector2(transform.position.x + speed, transform.position.y);
        }
        else
        {
            transform.position = new Vector2(transform.position.x - speed, transform.position.y);
        }
        if (transform.position.x >= Border)
        {
            xMove = false;
        }
        else if (transform.position.x <= -Border)
        {
            xMove = true;
        }



    }
}


