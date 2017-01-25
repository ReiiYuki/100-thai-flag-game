using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drone : MonoBehaviour {
	public Transform target;
	public float speed = 0.1f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x != target.position.x && transform.position.y != target.position.y) {
			transform.position = new Vector2 (transform.position.x + ((target.position.x - transform.position.x) * speed), transform.position.y + ((target.position.y - transform.position.y) * speed));
		}
	}
}
