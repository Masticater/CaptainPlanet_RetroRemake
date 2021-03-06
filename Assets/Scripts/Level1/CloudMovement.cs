﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMovement : MonoBehaviour
{

    public float speed;
    public float minX; //Furthest left a cloud can reach

    void FixedUpdate() //Move the clouds left until they are off screen, then restart their "Animation"
    {
        Vector3 pos = transform.position;
        pos -= new Vector3(speed, 0) * Time.deltaTime;
        transform.position = pos;

        if (transform.position.x <= minX)
            transform.position = new Vector3(-minX, transform.position.y, transform.position.z);
    }
}
