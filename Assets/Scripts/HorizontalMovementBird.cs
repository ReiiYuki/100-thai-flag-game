using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// A bird that moves horizontally
public class HorizontalMovementBird : Bird {

	public Vector2 originalPosition;
	public Vector2 finalPosition;
	public float startTime;
	public float distance;

	// Use this for initialization
	void Start () {
		startTime = Time.time;
		originalPosition = gameObject.transform.position;
		finalPosition = new Vector2(-gameObject.transform.position.x, gameObject.transform.position.y);
		distance = Vector2.Distance (originalPosition, finalPosition);
	}
	
	// Update is called once per frame
	void Update () {
        if (!isPause)
		    this.Fly ();
	}

	public override void Fly() {
		float fracDistance = (Time.time - startTime) * flyingSpeed / distance;
		gameObject.transform.position = Vector2.Lerp (originalPosition, finalPosition, fracDistance );
	}
		
}
