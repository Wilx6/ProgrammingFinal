using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D rb;
    public float jump;
    public float speed;
    private float Move;


    // Start is called before the first frame update
    void Start()
    {


        rb = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void Update()
    {
        Move = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(Move * speed, rb.velocity.y);

        if (Input.GetKeyDown("space"))
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump));
        }


    }
}
