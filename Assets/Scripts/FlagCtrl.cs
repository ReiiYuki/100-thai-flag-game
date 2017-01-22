﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagCtrl : MonoBehaviour {

	// Physics of the flag
	private Rigidbody2D physic2D;

	// Scalar value of force to be added to flag's Rigidbody2D
	// Exposed on inspector
	public float forceMagnitude = 7.5f;
	public bool hasStarted = false;
	private bool hasDied = false;
	private GameObject topAnchor;
	private GameObject bottomAnchor;
	private int hitPoint = 1;

	void Awake() {
		//Reference physic2D to flag's Rigidbody2D
		physic2D = GetComponent<Rigidbody2D> ();
		//Remove flag from physics simulation
		physic2D.Sleep ();	
	}

	// Use this for initialization
//	void Start () {
//	}
	
	// Update is called once per frame
	void Update () {
		// Start Physics simulation and take user's inputs 
		// [Condition] Any button is pressed
		if (hasStarted) {
			// S or DownArrow add force up to the flag
			if (Input.GetKeyDown (KeyCode.S) || Input.GetKeyDown (KeyCode.DownArrow)) {
				physic2D.AddForce (Vector2.up * forceMagnitude, ForceMode2D.Impulse);
			}
			// A or LeftArrow add force up and to the left of the flag
			if (Input.GetKeyDown (KeyCode.A) || Input.GetKeyDown (KeyCode.LeftArrow)) {
				physic2D.AddForce ((Vector2.up + Vector2.left) * forceMagnitude, ForceMode2D.Impulse);
			}
			// D or RightArrow add force up and to the right of the flag	
			if (Input.GetKeyDown (KeyCode.D) || Input.GetKeyDown (KeyCode.RightArrow)) {
				physic2D.AddForce ((Vector2.up + Vector2.right) * forceMagnitude, ForceMode2D.Impulse);
			}
			
		} else if (Input.anyKeyDown && !hasStarted) {
			hasStarted = true;
			physic2D.WakeUp ();
		} 
	}

	void OnTriggerEnter2D (Collider2D other) {
        if (other.tag == "Win")
            print("You win");
        if (other.tag == "Obtacle")
        {
            print("You got hit by a bird R.I.P");
            print("Move to Play again scene");
        }
        Time.timeScale = 0;
	}
}