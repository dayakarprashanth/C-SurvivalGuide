using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //If spacebar is pressed
        //Print a message 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space bar is Pressed");
        }

        //If E is pressed down
        //Print a message till it is lifted up
        if (Input.GetKey(KeyCode.E))
        {
            Debug.Log("e is pressed and not lifted");
        }

        //If F is pressed down
        //Print a message when the key is released
        if (Input.GetKeyUp(KeyCode.F))
        {
            Debug.Log("F is released");
        }

     


    }
}
