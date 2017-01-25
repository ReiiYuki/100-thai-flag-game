﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Airplane : MonoBehaviour {
	public Vector2 finish;
	public float speed = 0.1f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x != finish.x && transform.position.y != finish.y) {
			transform.position = new Vector2 (transform.position.x + ((finish.x - transform.position.x) * speed), transform.position.y + ((finish.y - transform.position.y) * speed));
		}
	}
}