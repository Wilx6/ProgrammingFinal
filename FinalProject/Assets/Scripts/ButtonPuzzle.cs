using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPuzzle : MonoBehaviour
{
    public bool orangeButton = false;
    public bool blueButton = false;
    public bool redButton = false;

    public void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0) && gameObject.tag == "Orange")
        {
            orangeButton = true;
            Debug.Log("Orange Was Clicked");
        }

        if (Input.GetMouseButtonDown(0) && gameObject.tag == "Blue")
        {
            blueButton = true;
            Debug.Log("Blue Was Clicked");
        }

        if (Input.GetMouseButtonDown(0) && gameObject.tag == "Red")
        {
            redButton = true;
            Debug.Log("Red Was Clicked");
        }
    }
}      