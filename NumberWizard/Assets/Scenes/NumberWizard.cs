using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	void Start () {

        int max = 1000;
        int min = 1;
        int guess = max / min;

        Debug.Log("Welcome to Number Wizard");
        Debug.Log("Pick a number--don't tell me what it is!");
        Debug.Log("The highest number you may choose is: " + max);
        Debug.Log("The lowest number you may choose is: " + min);
        Debug.Log("Tell me if your number is higher or lower than " + guess);
        Debug.Log("Press Up for Higher, Press Down for Lower, and Press Enter for Correct");
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            Debug.Log("You Pressed Up");
        }
	}
}
