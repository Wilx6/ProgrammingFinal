using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UnlockDoor : MonoBehaviour
{

    public ButtonPuzzle checkIfOrange;
    public ButtonPuzzle checkIfBlue;
    public ButtonPuzzle checkIfRed;

    public SpriteRenderer sp;
    public Sprite newSprite;
    public bool changed = false;


    void Start()
    {
        sp = gameObject.GetComponent<SpriteRenderer>();
    }

    public void Update()
    {
        checkIfOrange = GameObject.FindWithTag("Orange").GetComponent<ButtonPuzzle>();
        checkIfBlue = GameObject.FindWithTag("Blue").GetComponent<ButtonPuzzle>();
        checkIfRed = GameObject.FindWithTag("Red").GetComponent<ButtonPuzzle>();
    }

    public void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0) && gameObject.tag == "Door" && checkIfOrange.orangeButton == true && checkIfBlue.blueButton == true && checkIfRed.redButton == true)
        {
            ChangeSprite();
            changed = true;
        }
    }

    void ChangeSprite()
    {
        if (!changed && checkIfOrange == true && checkIfBlue == true && checkIfRed == true)
        {
            sp.sprite = newSprite;
        }
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Door" && changed == true)
        {
            SceneManager.LoadScene(2);
        }

    }


}
