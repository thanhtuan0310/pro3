﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackGround : MonoBehaviour
{
    private Vector3 startpos;
    private float width;
    // Start is called before the first frame update
    void Start()
    {
        startpos = transform.position;
        width = GetComponent<BoxCollider>().size.x/2;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < startpos.x - width)
        {
            transform.position = startpos;
        }
    }
}
