﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeObject : MonoBehaviour

    
{
    public Vector3 startPosition;
    // Start is called before the first frame update
    void Start()
    {
        //startPosition = new Vector3(4,5,6);
        transform.position = startPosition;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
