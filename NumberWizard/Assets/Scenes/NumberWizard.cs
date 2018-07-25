using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    int max = 1000;
    int min = 1;
    int guess = 500;

	// Use this for initialization
	void Start () {
        
        Debug.Log("Welcome to Number Wizard");
        Debug.Log("Pick a number--don't tell me what it is!");
        Debug.Log("The highest number you may choose is: " + max);
        Debug.Log("The lowest number you may choose is: " + min);
        Debug.Log("Tell me if your number is higher or lower than " + guess);
        Debug.Log("Press Up for Higher, Press Down for Lower, and Press Enter for Correct");
        max = max + 1;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            min = guess;
            guess = (max + min) / 2;
            Debug.Log("Is your number " + guess + " ?");
        }
        else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            max = guess;
            guess = (max + min) / 2;
            Debug.Log("Is your number " + guess + " ?");
        }
        else if (Input.GetKeyUp(KeyCode.Return))
        {
            Debug.Log("Your number is " + guess);
        }    
	}
}
