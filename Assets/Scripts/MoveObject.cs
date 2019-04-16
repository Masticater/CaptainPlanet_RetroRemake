﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{

	void Start()
	{
	
	}

    public Vector3 moveDirection;

    void Update()
    {
        transform.position += moveDirection * Time.deltaTime;

        if(transform.position.x <= 2.3f && CompareTag("EnemyBase"))
        {
            GetComponent<MoveObject>().enabled = false;
        }
    }
}