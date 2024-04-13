using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Bird : MonoBehaviour
{

    public float xSpeed = 0.01f;
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

        if (Input.GetKey(KeyCode.Space))
        {
            rb2d.AddForce(Vector2.up * direction);
        }

       



    }
}


