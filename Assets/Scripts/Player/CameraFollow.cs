﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour 
{
	Vector3 offset;
	public Transform player;

	void Start () {
		offset = transform.position - player.position;
	}

	void FixedUpdate () {
        if (player != null)
            transform.position = player.position + offset;
	}

}
