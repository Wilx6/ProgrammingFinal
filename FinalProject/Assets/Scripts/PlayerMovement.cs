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

    public UnlockDoor doorScript;


    // Start is called before the first frame update
    void Start()
    {


        rb = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void Update()
    {
        doorScript = GameObject.FindWithTag("Door").GetComponent<UnlockDoor>();
        

        Move = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(Move * speed, rb.velocity.y);

        if (Input.GetKeyDown("space"))
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump));
        }


    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            transform.position = new Vector2(16.57f, 2.79f);
        }

        if (other.tag == "Door" && doorScript.changed == true)
        {
            SceneManager.LoadScene(2);
        }
    }
    
}
